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
    public partial class IdentifyFingerprint : Form
    {
        public IdentifyFingerprint()
        {
            InitializeComponent();
        }

        private NFExtractor _extractor;
		private NMatcher _matcher;

		private NFView _nfView;

		private NBuffer[] _templates;
		private string[] _templatesNames;
		private NBuffer _template;

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

		private void UseQuality()
		{
			if (UseQualityCheckBox.Checked)
			{
				_extractor.UseQuality = true;
				_extractor.QualityThreshold = Utils.QualityFromPercent((int)thresholdNumericUpDown.Value);
				thresholdNumericUpDown.Enabled = true;
				defaultButton.Enabled = true;
				setButton.Enabled = false;
			}
			else
			{
				_extractor.UseQuality = false;
				thresholdNumericUpDown.Enabled = false;
				defaultButton.Enabled = false;
				setButton.Enabled = false;
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

		private void IdentifyFingerLoad(object sender, EventArgs e)
		{
			fileForIdentificationLabel.Text = string.Empty;
			templatesCountLabel.Text = @"0";

			try
			{
				_nfView = new NFView();
				_nfView.Dock = DockStyle.Fill;
				_nfView.AutoScroll = true;
				panel.Controls.Add(_nfView);

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

		private void OpenTemplatesButtonClick(object sender, EventArgs e)
		{
			identifyButton.Enabled = false;

			templatesCountLabel.Text = @"0";
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
			_nfView.Image = null;
			if (_nfView.Template != null)
			{
				_nfView.Template.Dispose();
				_nfView.Template = null;
			}

			openFileDialog.Filter = NImages.GetOpenFileFilterString(true, true);

			openFileDialog.Title = @"Open Image File";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileForIdentificationLabel.Text = string.Empty;
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

					// extract a fingerprint template from the image for showing
					NfeExtractionStatus extractionStatus;
					NFRecord record = _extractor.Extract(grayscaleImage, NFPosition.Unknown, NFImpressionType.LiveScanPlain, out extractionStatus);
					if (extractionStatus == NfeExtractionStatus.TemplateCreated)
					{
						// save to byte array
						_template = record.Save();

						_nfView.Image = grayscaleImage.ToBitmap();

						_nfView.Template = record;
					}
					else
					{
						MessageBox.Show(@"Fingerprint image is of low quality. The template was not extracted.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void SetButtonClick(object sender, EventArgs e)
		{
			UseQuality();
		}

		private void UseQualityCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			UseQuality();
		}

		private void DefaultButtonClick(object sender, EventArgs e)
		{
			thresholdNumericUpDown.Value = 39;
			UseQuality();
			defaultButton.Enabled = false;
		}

		private void ThresholdNumericUpDownEnter(object sender, EventArgs e)
		{
			setButton.Enabled = true;
			defaultButton.Enabled = true;
		}

		private void MatchingFarComboBoxEnter(object sender, EventArgs e)
		{
			setMatchingFARButton.Enabled = true;
			defaultMatchingFARButton.Enabled = true;
		}

		private void SetMatchingFarButtonClick(object sender, EventArgs e)
		{
			SetMatchingThreshold();
		}

		private void DefaultMatchingFarButtonClick(object sender, EventArgs e)
		{
			matchingFarComboBox.SelectedIndex = 1;
			defaultMatchingFARButton.Enabled = false;
			setMatchingFARButton.Enabled = false;
		}

		private void IdentifyFingerVisibleChanged(object sender, EventArgs e)
		{
			if (Visible)
			{
				if (_extractor != null) UseQuality();
				if (_matcher != null) SetMatchingThreshold();
			}
		}
	}
}
