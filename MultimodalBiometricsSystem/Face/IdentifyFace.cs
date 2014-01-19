using System;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Images;
using Neurotec.IO;
using Neurotec.Samples;

namespace MultimodalBiometricsSystem.Face
{
    public partial class IdentifyFace : Form
    {
        public IdentifyFace()
        {
            InitializeComponent();
        }

        private NLExtractor _extractor;
		private NMatcher _matcher;
		private NBuffer[] _templates;
		private string[] _templatesNames;
		private NBuffer _template;

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

		private void SetMatchingThreshold()
		{
			try
			{
				_matcher.MatchingThreshold = Utils.MatchingThresholdFromString(matchingFarComboBox.Text);
				matchingFarComboBox.Text = Utils.MatchingThresholdToString(_matcher.MatchingThreshold);
				setMatchingFARButton.Enabled = false;
			}
			catch
			{
				matchingFarComboBox.Select();
				MessageBox.Show(@"FAR is not valid", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void MatchingFarComboBoxEnter(object sender, EventArgs e)
		{
			setMatchingFARButton.Enabled = true;
			defaultMatchingFARButton.Enabled = true;
		}

		private void OpenTemplatesButtonClick(object sender, EventArgs e)
		{
			identifyButton.Enabled = false;

			templatesCountLabel.Text = @"0";
			_templates = null;
			openFileDialog.Multiselect = true;
			openFileDialog.FileName = null;
			openFileDialog.Filter = @"Template files (*.dat)|*.dat";
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
				templatesCountLabel.Text = openFileDialog.FileNames.Length.ToString();
			}
			if (_templates != null && _template != null)
			{
				identifyButton.Enabled = true;
			}
		}

		private void OpenImageButtonClick(object sender, EventArgs e)
		{
			identifyButton.Enabled = false;

			openFileDialog.FileName = null;
			openFileDialog.Filter = string.Empty;

			_template = null;
			facesView.Image = null;

			openFileDialog.Filter = NImages.GetOpenFileFilterString(true, true);

			openFileDialog.Title = @"Open Image File";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileForIdentificationLabel.Text = string.Empty;
				try
				{
					// read image
					NImage image = NImage.FromFile(openFileDialog.FileName);
					facesView.Image = image.ToBitmap();

					// convert image to grayscale
					NGrayscaleImage grayscaleImage = image.ToGrayscale();

					// extract a template from the image for matching
					NleExtractionStatus extractionStatus;
					NleDetectionDetails details;
					NLTemplate template = _extractor.Extract(grayscaleImage, out details, out extractionStatus);
					if (extractionStatus == NleExtractionStatus.TemplateCreated)
					{
						_template = template.Save();
						facesView.DetectionDetails = new NleDetectionDetails[] { details };
					}
					else
					{
						MessageBox.Show(string.Format("Template was not extracted: {0}.", extractionStatus), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					fileForIdentificationLabel.Text = openFileDialog.FileName;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("Error {0}", ex), Text,
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (_templates != null && _template != null)
			{
				identifyButton.Enabled = true;
			}
		}

		private void IdentifyButtonClick(object sender, EventArgs e)
		{
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

		private void SetMatchingFARButtonClick(object sender, EventArgs e)
		{
			SetMatchingThreshold();
		}

		private void DefaultMatchingFARButtonClick(object sender, EventArgs e)
		{
			matchingFarComboBox.SelectedIndex = 1;
			defaultMatchingFARButton.Enabled = false;
			setMatchingFARButton.Enabled = true;
		}

		private void IdentifyFaceLoad(object sender, EventArgs e)
		{
			try
			{
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
    }
}
