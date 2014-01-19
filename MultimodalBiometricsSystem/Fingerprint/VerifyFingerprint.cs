using System;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Gui;
using Neurotec.Images;
using Neurotec.IO;
using Neurotec.Samples;

namespace MultimodalBiometricsSystem.Fingerprint
{
    public partial class VerifyFingerprint : Form
    {
        public VerifyFingerprint()
        {
            InitializeComponent();
        }

        private NFExtractor _extractor;
		private NMatcher _matcher;

		private NBuffer _template1;
		private NBuffer _template2;
		private NFView _nfView1;
		private NFView _nfView2;

		public NFExtractor Extractor
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

		private void SetMatchingThreshold()
		{
			try
			{
				_matcher.MatchingThreshold = Utils.MatchingThresholdFromString(matchingFarComboBox.Text);
				matchingFarComboBox.Text = Utils.MatchingThresholdToString(_matcher.MatchingThreshold);
				setButton.Enabled = false;
				if (_template1 != null && _template2 != null)
				{
					verifyButton.Enabled = true;
				}
			}
			catch
			{
				matchingFarComboBox.Select();
				MessageBox.Show(@"FAR is not valid", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string OpenImageTemplate(out NBuffer template, NFView nfView)
		{
			template = null;
			nfView.Image = null;
			if (nfView.Template != null)
			{
				nfView.Template.Dispose();
				nfView.Template = null;
			}
			nfView.Width = 0;
			nfView.Height = 0;
			msgLabel.Text = string.Empty;
			string fileLocation = string.Empty;

			openFileDialog.FileName = null;
			openFileDialog.Title = @"Open Template";
			if (openFileDialog.ShowDialog() == DialogResult.OK) // load template
			{
				fileLocation = openFileDialog.FileName;

				// Check if given file is a template
				NBuffer fileData = new NBuffer(File.ReadAllBytes(openFileDialog.FileName));
				try
				{
					NTemplate.Check(fileData);
					template = fileData;
				}
				catch { }

				// If file is not a template, try to load it as image
				if (template == null)
				{
					try
					{
						// read image
						NImage image = NImage.FromFile(openFileDialog.FileName);

						// convert image to grayscale
						NGrayscaleImage grayscaleImage = image.ToGrayscale();
						if (grayscaleImage.ResolutionIsAspectRatio
								|| grayscaleImage.HorzResolution < 250
								|| grayscaleImage.VertResolution < 250)
						{
							grayscaleImage.HorzResolution = 500;
							grayscaleImage.VertResolution = 500;
							grayscaleImage.ResolutionIsAspectRatio = false;
						}

						nfView.Width = (int)image.Width;
						nfView.Height = (int)image.Height;
						nfView.Image = grayscaleImage.ToBitmap();

						// extract a fingerprint template from the image for showing
						NfeExtractionStatus extractionStatus;
						NFRecord record = _extractor.Extract(grayscaleImage, NFPosition.Unknown, NFImpressionType.LiveScanPlain, out extractionStatus);
						if (extractionStatus == NfeExtractionStatus.TemplateCreated)
						{
							// save record to byte array
							template = record.Save();

							nfView.Template = record;
						}
						else
						{
							MessageBox.Show(@"Fingerprint image is of low quality. The template was not extracted.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(string.Format("Error {0}", ex), Text,
								MessageBoxButtons.OK, MessageBoxIcon.Error);
						return string.Empty;
					}
				}
			}
			if (_template1 != null && _template2 != null)
			{
				verifyButton.Enabled = true;
			}
			return fileLocation;
		}

		private void OpenImageButton1Click(object sender, EventArgs e)
		{
			templateLeftLabel.Text = string.Empty;
			templateLeftLabel.Text = OpenImageTemplate(out _template1, _nfView1);
		}

		private void OpenImageButton2Click(object sender, EventArgs e)
		{
			templateRightLabel.Text = string.Empty;
			templateRightLabel.Text = OpenImageTemplate(out _template2, _nfView2);
		}

		private void MatchingFarComboBoxEnter(object sender, EventArgs e)
		{
			setButton.Enabled = true;
			defaultButton.Enabled = true;
		}

		private void SetButtonClick(object sender, EventArgs e)
		{
			SetMatchingThreshold();
		}

		private void DefaultButtonClick(object sender, EventArgs e)
		{
			matchingFarComboBox.SelectedIndex = 1;
			defaultButton.Enabled = false;
			setButton.Enabled = false;
		}

		private void ClearImagesButtonClick(object sender, EventArgs e)
		{
			_template1 = null;
			_template2 = null;
			verifyButton.Enabled = false;

			_nfView1.Image = null;
			if (_nfView1.Template != null)
			{
				_nfView1.Template.Dispose();
				_nfView1.Template = null;
			}

			_nfView2.Image = null;
			if (_nfView2.Template != null)
			{
				_nfView2.Template.Dispose();
				_nfView2.Template = null;
			}

			msgLabel.Text = string.Empty;
			templateLeftLabel.Text = string.Empty;
			templateRightLabel.Text = string.Empty;
		}

		private void VerifyFingerLoad(object sender, EventArgs e)
		{
			msgLabel.Text = string.Empty;
			try
			{
				_nfView1 = new NFView();
				_nfView1.Dock = DockStyle.Fill;
				_nfView1.AutoScroll = true;
				panel1.Controls.Add(_nfView1);

				_nfView2 = new NFView();
				_nfView2.Dock = DockStyle.Fill;
				_nfView2.AutoScroll = true;
				panel2.Controls.Add(_nfView2);

				templateLeftLabel.Text = string.Empty;
				templateRightLabel.Text = string.Empty;

				matchingFarComboBox.BeginUpdate();
				matchingFarComboBox.Items.Add(0.001.ToString("P1"));
				matchingFarComboBox.Items.Add(0.0001.ToString("P2"));
				matchingFarComboBox.Items.Add(0.00001.ToString("P3"));
				matchingFarComboBox.EndUpdate();
				matchingFarComboBox.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void VerifyButtonClick(object sender, EventArgs e)
		{
			SetMatchingThreshold();
			if (_template1 != null && _template2 != null)
			{
				try
				{
					int score = _matcher.Verify(_template1, _template2);
					string msg = string.Format("Score of matched templates: {0}", score);
					MessageBox.Show(msg);
					msgLabel.Text = msg;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("Error {0}", ex), Text,
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			verifyButton.Enabled = false;
		}
	}
}
