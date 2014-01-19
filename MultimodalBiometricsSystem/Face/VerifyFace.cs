using System;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Gui;
using Neurotec.Images;
using Neurotec.IO;
using Neurotec.Samples;

namespace MultimodalBiometricsSystem.Face
{
    public partial class VerifyFace : Form
    {
        public VerifyFace()
        {
            InitializeComponent();
        }

        private NLExtractor _extractor;
		private NMatcher _matcher;
		private NBuffer _template1;
		private NBuffer _template2;

		public NLExtractor Extractor
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

		private string OpenImageTemplate(out NBuffer template, NLView nlView)
		{
			template = null;
			nlView.Image = null;
			nlView.DetectionDetails = null;
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
						nlView.Image = image.ToBitmap();

						// convert image to grayscale
						NGrayscaleImage grayscaleImage = image.ToGrayscale();

						// extract a template from the image
						NleExtractionStatus extractionStatus;
						NleDetectionDetails details;
						NLTemplate tmpl = _extractor.Extract(grayscaleImage, out details, out extractionStatus);
						if (extractionStatus == NleExtractionStatus.TemplateCreated)
						{
							template = tmpl.Save();
							nlView.DetectionDetails = new NleDetectionDetails[] { details };
						}
						else
						{
							MessageBox.Show(string.Format("The template was not extracted: {0}.", extractionStatus), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void OpenImageButton1Click(object sender, EventArgs e)
		{
			templateLeftLabel.Text = string.Empty;
			templateLeftLabel.Text = OpenImageTemplate(out _template1, nlView1);
		}

		private void OpenImageButton2Click(object sender, EventArgs e)
		{
			templateRightLabel.Text = string.Empty;
			templateRightLabel.Text = OpenImageTemplate(out _template2, nlView2);
		}

		private void VerifyFaceLoad(object sender, EventArgs e)
		{
			msgLabel.Text = string.Empty;
			try
			{
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

			nlView1.Image = null;
			nlView1.DetectionDetails = null;

			nlView2.Image = null;
			nlView2.DetectionDetails = null;

			msgLabel.Text = string.Empty;
			templateLeftLabel.Text = string.Empty;
			templateRightLabel.Text = string.Empty;
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
