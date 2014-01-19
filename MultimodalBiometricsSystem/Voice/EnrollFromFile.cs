using System;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.IO;
using Neurotec.Media;
using Neurotec.Sound;

namespace MultimodalBiometricsSystem.Voice
{
    public partial class EnrollFromFile : Form
    {
        public EnrollFromFile()
        {
            InitializeComponent();
        }

        private NSExtractor _extractor;
		private NBuffer _template;
		private NMediaReader _reader;

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

		private void EnrollFromFileLoad(object sender, EventArgs e)
		{
			lblSoundFile.Text = string.Empty;
			lblStatus.Text = string.Empty;
			btnExtract.Enabled = false;
			btnSaveTemplate.Enabled = false;
		}

		private void BtnOpenClick(object sender, EventArgs e)
		{
			_template = null;
			if (_reader != null)
			{
				_reader.Dispose();
				_reader = null;
			}
			lblSoundFile.Text = string.Empty;
			lblStatus.Text = string.Empty;
			btnExtract.Enabled = false;
			btnSaveTemplate.Enabled = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					_reader = new NMediaReader(openFileDialog.FileName, NMediaType.Audio, false);
					lblSoundFile.Text = openFileDialog.FileName;
					btnExtract.Enabled = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("Error: {0}", ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void BtnExtractClick(object sender, EventArgs e)
		{
			_template = null;
			btnSaveTemplate.Enabled = false;
			lblStatus.Text = string.Empty;

			if (!SetExtractorParams()) return;

			NseExtractionStatus extractionStatus = NseExtractionStatus.None;
			NSRecord record = null;
			try
			{
				_reader.Start();
				_extractor.ExtractStart(Convert.ToInt32(nudPhraseId.Value));
				while (true)
				{
					using (NSoundBuffer soundSample = _reader.ReadAudioSample())
					{
						if (soundSample != null)
						{
							extractionStatus = _extractor.ExtractNext(soundSample);
						}

						if (extractionStatus != NseExtractionStatus.None || soundSample == null)
						{
							record = _extractor.ExtractEnd(out extractionStatus);
							break;
						}
					}
				}

				if (extractionStatus == NseExtractionStatus.TemplateCreated)
				{
					_template = record.Save();
					record.Dispose();
					btnSaveTemplate.Enabled = true;
					lblStatus.Text = "Template extracted";
				}
				else
				{
					MessageBox.Show(@"Extraction failed");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Extraction failed: {0}", ex), @"Extraction failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_reader.Stop();
			}
		}

		private void BtnSaveTemplateClick(object sender, EventArgs e)
		{
			if (_template != null)
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						File.WriteAllBytes(saveFileDialog.FileName, _template.ToArray());
					}
					catch (Exception ex)
					{
						MessageBox.Show(string.Format("Error: {0}", ex), @"Error saving template", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void ChbAutoDetectCheckedChanged(object sender, EventArgs e)
		{
			nudPauseDuration.Enabled = chbAutoDetect.Checked;
		}
	}
}
