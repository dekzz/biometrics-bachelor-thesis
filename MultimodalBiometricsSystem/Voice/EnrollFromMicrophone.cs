using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Devices;
using Neurotec.IO;
using Neurotec.Sound;
using Neurotec.Sound.Processing;

namespace MultimodalBiometricsSystem.Voice
{
    public partial class EnrollFromMicrophone : Form
    {
        public EnrollFromMicrophone()
        {
            InitializeComponent();
        }

        private NSExtractor _extractor;
		private NDeviceManager _deviceManager;
		private NMicrophone _microphone;
		private NBuffer _template;
		private bool _finishCapture;

		public NSExtractor Extractor
		{
			get
			{
				return _extractor;
			}
			set
			{
				_extractor = value;
			}
		}

		public void StopCapturing()
		{
			_finishCapture = true;
		}

		private void UpdateDeviceList()
		{
			lbMicrophones.BeginUpdate();
			try
			{
				_deviceManager.Refresh();
				lbMicrophones.Items.Clear();
				foreach (NDevice item in _deviceManager.Devices)
				{
					lbMicrophones.Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error: {0}", ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				lbMicrophones.EndUpdate();
			}
		}

		private bool SetExtractorParams()
		{
			try
			{
				_extractor.UseSpeakerDetection = chbAutoDetect.Checked;
				_extractor.MaxPauseDurationRaw = Convert.ToInt32(nudPauseDuration.Value * 1000);
				_extractor.MaxPhraseDurationRaw = Convert.ToInt32(nudMaxPhraseDuration.Value * 1000);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Failed to set parameters: {0}", ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private delegate void ShowSoundLevelDelegate(double soundLevel);
		private void ShowSoundLevel(double soundLevel)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new ShowSoundLevelDelegate(ShowSoundLevel), soundLevel);
				return;
			}

			int levelValue = (int)(soundLevel * 100.0);
			if (levelValue > 100) levelValue = 100;
			pbSoundLevel.Value = levelValue;
		}

		private void EnrollFromMicrophoneLoad(object sender, EventArgs e)
		{
			lblStatus.Text = string.Empty;
			if (!DesignMode)
			{
				_deviceManager = new NDeviceManager(NDeviceType.Microphone, true, false);
				UpdateDeviceList();
			}
		}

		private void BtnStartClick(object sender, EventArgs e)
		{
			_microphone = lbMicrophones.SelectedItem as NMicrophone;
			if (_microphone == null)
			{
				MessageBox.Show("Please select a microphone");
				return;
			}

			if (!SetExtractorParams()) return;

			_finishCapture = false;
			_template = null;
			btnSaveTemplate.Enabled = false;
			btnStart.Enabled = false;
			btnStop.Enabled = true;
			btnRefresh.Enabled = false;
			gbOptions.Enabled = false;
			lbMicrophones.Enabled = false;
			lblStatus.Text = string.Empty;

			backgroundWorker.RunWorkerAsync((int)nudPhraseId.Value);
		}

		private void BtnStopClick(object sender, EventArgs e)
		{
			StopCapturing();
		}

		private void BtnRefreshClick(object sender, EventArgs e)
		{
			UpdateDeviceList();
		}

		private void ChbAutoDetectCheckedChanged(object sender, EventArgs e)
		{
			nudPauseDuration.Enabled = chbAutoDetect.Checked;
		}

		private void BtnSaveTemplateClick(object sender, EventArgs e)
		{
			if (_template != null)
			{
				saveFileDialog.FileName = string.Empty;
				saveFileDialog.Filter = string.Empty;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						File.WriteAllBytes(saveFileDialog.FileName, _template.ToArray());
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, @"Error saving template", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void WorkerDoWork(object sender, DoWorkEventArgs e)
		{
			int phraseId = (int)e.Argument;
			bool extractionStarted = false;
			try
			{
				_microphone.StartCapturing();
				while (true)
				{
					using (NSoundBuffer soundSample = _microphone.GetSoundSample())
					{
						NseExtractionStatus extractionStatus = NseExtractionStatus.None;
						if (soundSample != null)
						{
							double soundLevel = NSoundProc.GetSoundLevel(soundSample);
							ShowSoundLevel(soundLevel);
							if (!extractionStarted)
							{
								_extractor.ExtractStart(phraseId);
								_template = null;
								extractionStarted = true;
								_finishCapture = false;
							}
							extractionStatus = _extractor.ExtractNext(soundSample);
						}

						if (extractionStatus != NseExtractionStatus.None || _finishCapture || soundSample == null)
						{
							if (extractionStarted)
							{
								NSRecord record = _extractor.ExtractEnd(out extractionStatus);
								if (extractionStatus == NseExtractionStatus.TemplateCreated)
								{
									_template = record.Save();
									record.Dispose();
								}
								extractionStarted = false;
							}
							e.Result = extractionStatus;
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error: {0}", ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (extractionStarted)
				{
					NseExtractionStatus status;
					_extractor.ExtractEnd(out status);
				}
			}
		}

		private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Result != null)
			{
				NseExtractionStatus status = (NseExtractionStatus)e.Result;
				if(status != NseExtractionStatus.None)
					lblStatus.Text = status.ToString();
			}

			_microphone.StopCapturing();

			btnSaveTemplate.Enabled = _template != null;
			gbOptions.Enabled = true;
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			btnRefresh.Enabled = true;
			lbMicrophones.Enabled = true;
			pbSoundLevel.Value = 0;
		}
	}
}
