using System;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.IO;
using Neurotec.Media;
using Neurotec.Sound;
using Neurotec.Samples;

namespace MultimodalBiometricsSystem.Voice
{
    public partial class IdentifyVoice : Form
    {
        public IdentifyVoice()
        {
            InitializeComponent();
        }

        private NSExtractor _extractor;
		private NMatcher _matcher;

		private NBuffer[] _templates;
		private string[] _templatesNames;
		private NBuffer _template;

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

		public NMatcher Matcher
		{
			get
			{
				return _matcher;
			}
			set
			{
				_matcher = value;
			}
		}

		private bool SetMatchingThreshold()
		{
			try
			{
				_matcher.MatchingThreshold = Utils.MatchingThresholdFromString(cbMatchingFar.Text);
				cbMatchingFar.Text = Utils.MatchingThresholdToString(_matcher.MatchingThreshold);
				btnSet.Enabled = false;
				return true;
			}
			catch
			{
				MessageBox.Show(@"FAR is not valid", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				cbMatchingFar.Select();
				return false;
			}
		}

		private void BtnOpenTemplatesClick(object sender, EventArgs e)
		{
			btnIdentify.Enabled = false;

			lblTemplatesCount.Text = @"0";
			_templates = null;
			openFileDialog.Multiselect = true;
			openFileDialog.FileName = null;
			openFileDialog.Filter = @"Template files (*.dat)|*.dat|All files (*.*)|*.*";
			openFileDialog.Title = @"Open Templates Files";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				int templatesCount = openFileDialog.FileNames.Length;
				_templates = new NBuffer[templatesCount];
				_templatesNames = new string[templatesCount];
				for (int i = 0; i < templatesCount; ++i)
				{
					_templates[i] = new NBuffer(File.ReadAllBytes(openFileDialog.FileNames[i]));
					DirectoryInfo directoryInfo = new DirectoryInfo(openFileDialog.FileNames[i]);
					_templatesNames[i] = directoryInfo.Name;
				}
				lblTemplatesCount.Text = openFileDialog.FileNames.Length.ToString();
			}
			if (_templates != null && _template != null)
			{
				btnIdentify.Enabled = true;
			}
		}

		private void BtnOpenAudioFileClick(object sender, EventArgs e)
		{
			btnIdentify.Enabled = false;

			openFileDialog.FileName = null;
			openFileDialog.Filter = string.Empty;

			lblFileForIdentification.Text = string.Empty;
			_template = null;

			openFileDialog.Title = @"Open Audio File";
			openFileDialog.FileName = null;
			openFileDialog.Filter = string.Empty;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				NseExtractionStatus extractionStatus = NseExtractionStatus.None;
				try
				{
					NMediaReader reader = new NMediaReader(openFileDialog.FileName, NMediaType.Audio, false);
					reader.Start();
					_extractor.ExtractStart(0);
					NSRecord record;
					while (true)
					{
						using (NSoundBuffer soundSample = reader.ReadAudioSample())
						{
							if (soundSample != null)
							{
								extractionStatus = _extractor.ExtractNext(soundSample);
							}

							if (extractionStatus != NseExtractionStatus.None || soundSample == null)
							{
								reader.Stop();
								record = _extractor.ExtractEnd(out extractionStatus);
								break;
							}
						}
					}

					if (extractionStatus == NseExtractionStatus.TemplateCreated)
					{
						_template = record.Save();
						lblFileForIdentification.Text = openFileDialog.FileName;
						record.Dispose();
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
			}

			if (_templates != null && _template != null)
			{
				btnIdentify.Enabled = true;
			}
		}

		private void BtnIdentifyClick(object sender, EventArgs e)
		{
			if (!SetMatchingThreshold()) return;

			try
			{

				listView.Items.Clear();
				if (_template != null && _templates.Length > 0)
				{
					try
					{
						_matcher.IdentifyStart(_template);
						for (int i = 0; i < _templates.Length; ++i)
						{
							int score = _matcher.IdentifyNext(_templates[i]);
							listView.Items.Add(new ListViewItem(new string[] { _templatesNames[i], score.ToString() }));
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
					finally
					{
						_matcher.IdentifyEnd();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void BtnSetClick(object sender, EventArgs e)
		{
			SetMatchingThreshold();
		}

		private void BtnDefaultClick(object sender, EventArgs e)
		{
			cbMatchingFar.SelectedIndex = 1;
			btnDefault.Enabled = false;
			btnSet.Enabled = false;
		}

		private void CbMatchingFarEnter(object sender, EventArgs e)
		{
			btnSet.Enabled = true;
			btnDefault.Enabled = true;
		}

		private void IdentifyVoiceLoad(object sender, EventArgs e)
		{
			lblFileForIdentification.Text = string.Empty;
			lblTemplatesCount.Text = @"0";

			try
			{
				cbMatchingFar.BeginUpdate();
				cbMatchingFar.Items.Add(0.001.ToString("P1"));
				cbMatchingFar.Items.Add(0.0001.ToString("P2"));
				cbMatchingFar.Items.Add(0.00001.ToString("P3"));
				cbMatchingFar.EndUpdate();
				cbMatchingFar.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
