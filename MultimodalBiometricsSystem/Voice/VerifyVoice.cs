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
    public partial class VerifyVoice : Form
    {
        public VerifyVoice()
        {
            InitializeComponent();
        }

        private NSExtractor _extractor;
		private NMatcher _matcher;

		private NBuffer _template1;
		private NBuffer _template2;

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
				_matcher.MatchingThreshold = Utils.MatchingThresholdFromString(cbMatchingFAR.Text);
				cbMatchingFAR.Text = Utils.MatchingThresholdToString(_matcher.MatchingThreshold);
				btnSet.Enabled = false;
				return true;
			}
			catch
			{
				MessageBox.Show(@"FAR is not valid", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				cbMatchingFAR.Select();
				return false;
			}
		}

		private string OpenTemplateOrFile(out NBuffer template)
		{
			template = null;
			string fileName = string.Empty;

			openFileDialog.FileName = string.Empty;
			openFileDialog.Filter = string.Empty;
			openFileDialog.Title = @"Open voice template or audio file";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] bytes = File.ReadAllBytes(openFileDialog.FileName);
				try
				{
					NTemplate.Check(bytes);
					template = new NBuffer(bytes);
					fileName = openFileDialog.FileName;
				}
				catch { }

				//file is audio
				if (template == null)
				{
					try
					{
						NseExtractionStatus extractionStatus = NseExtractionStatus.None;
						NSRecord record;

						NMediaReader reader = new NMediaReader(openFileDialog.FileName, NMediaType.Audio, false);
						reader.Start();
						_extractor.ExtractStart(0);
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
							template = record.Save();
							record.Dispose();
							fileName = openFileDialog.FileName;
						}
						else
						{
							MessageBox.Show(@"Extraction failed");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(string.Format("Error extracting: {0}", ex), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			return fileName;
		}

		private void BtnVerifyClick(object sender, EventArgs e)
		{
			if(!SetMatchingThreshold()) return;
			if (_template1 != null && _template2 != null)
			{
				try
				{
					int score = _matcher.Verify(_template1, _template2);
					string msg = string.Format("Score of matched templates: {0}", score);
					lblMsg.Text = msg;
					MessageBox.Show(msg);
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("Verification failed: {0}", ex), @"Verification error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void BtnSetClick(object sender, EventArgs e)
		{
			SetMatchingThreshold();
		}

		private void BtnDefaultClick(object sender, EventArgs e)
		{
			cbMatchingFAR.SelectedIndex = 1;
			btnDefault.Enabled = false;
			btnSet.Enabled = false;
		}

		private void BtnOpen1Click(object sender, EventArgs e)
		{
			lblFirstTemplate.Text = string.Empty;
			lblMsg.Text = string.Empty;
			btnVerify.Enabled = false;
			lblFirstTemplate.Text = OpenTemplateOrFile(out _template1);
			btnVerify.Enabled = _template1 != null && _template2 != null;
		}

		private void BtnOpen2Click(object sender, EventArgs e)
		{
			lblSecondTemplate.Text = string.Empty;
			lblMsg.Text = string.Empty;
			btnVerify.Enabled = false;
			lblSecondTemplate.Text = OpenTemplateOrFile(out _template2);
			btnVerify.Enabled = _template1 != null && _template2 != null;
		}

		private void CbMatchingFAREnter(object sender, EventArgs e)
		{
			btnSet.Enabled = true;
			btnDefault.Enabled = true;
		}

		private void VerifyVoiceLoad(object sender, EventArgs e)
		{
			lblMsg.Text = string.Empty;
			lblFirstTemplate.Text = string.Empty;
			lblSecondTemplate.Text = string.Empty;

			cbMatchingFAR.BeginUpdate();
			cbMatchingFAR.Items.Add(0.001.ToString("P1"));
			cbMatchingFAR.Items.Add(0.0001.ToString("P2"));
			cbMatchingFAR.Items.Add(0.00001.ToString("P3"));
			cbMatchingFAR.SelectedIndex = 1;
			cbMatchingFAR.EndUpdate();
		}
	}
}
