using System;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Images;
using Neurotec.IO;
using Neurotec.Samples;

namespace MultimodalBiometricsSystem.Fingerprint
{
    public partial class EnrollFromImage : Form
    {
        public EnrollFromImage()
        {
            InitializeComponent();

            openFileDialog.Filter = NImages.GetOpenFileFilterString(true, true);
            saveFileDialog.Filter = NImages.GetSaveFileFilterString();

            extractFeaturesButton.Enabled = false;
            saveImageButton.Enabled = false;
            saveTemplateButton.Enabled = false;
        }

        private NFExtractor _extractor;
        private NImage _image;
        private NGrayscaleImage _grayscaleImage;

        private NBuffer _template;
        private string _oldImageFilename = string.Empty;
        private string _oldTemplateFilename = string.Empty;

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

        private void OpenButtonClick(object sender, EventArgs e)
        {
            lblQuality.Text = string.Empty;
            pictureBox.Image = null;
            _template = null;
            nfView.Image = null;
            if (nfView.Template != null)
            {
                nfView.Template.Dispose();
                nfView.Template = null;
            }

            _image = null;

            openFileDialog.FileName = null;

            extractFeaturesButton.Enabled = false;
            saveImageButton.Enabled = false;
            saveTemplateButton.Enabled = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                _image = NImage.FromFile(openFileDialog.FileName);
                pictureBox.Image = _image.ToBitmap();
                extractFeaturesButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error opening file \"{0}\": {1}", openFileDialog.FileName, ex),
                                Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExtractFeaturesButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (_image != null)
                {
                    saveImageButton.Enabled = false;
                    saveTemplateButton.Enabled = false;

                    using (NImage clone = (NImage)_image.Clone())
                    {
                        _grayscaleImage = clone.ToGrayscale();
                    }
                    if (_grayscaleImage.ResolutionIsAspectRatio
                        || _grayscaleImage.HorzResolution < 250
                        || _grayscaleImage.VertResolution < 250)
                    {
                        _grayscaleImage.HorzResolution = 500;
                        _grayscaleImage.VertResolution = 500;
                        _grayscaleImage.ResolutionIsAspectRatio = false;
                    }
                    // extract a fingerprint template from the image for showing

                    NfeExtractionStatus extractionStatus;
                    NFRecord record = _extractor.Extract(_grayscaleImage, NFPosition.Unknown, NFImpressionType.LiveScanPlain, out extractionStatus);
                    // extract a fingerprint template from the image to byte array for saving
                    if (extractionStatus == NfeExtractionStatus.TemplateCreated)
                    {
                        lblQuality.Text = string.Format("Quality: {0}", record.Quality);

                        _template = record.Save();

                        nfView.Width = (int)_grayscaleImage.Width;
                        nfView.Height = (int)_grayscaleImage.Height;
                        nfView.Image = _grayscaleImage.ToBitmap();
                        nfView.Template = record;

                        saveImageButton.Enabled = true;
                        saveTemplateButton.Enabled = true;
                    }
                    else
                    {

                        _template = null;

                        lblQuality.Text = string.Empty;
                        nfView.Image = null;
                        if (nfView.Template != null)
                        {
                            nfView.Template.Dispose();
                            nfView.Template = null;
                        }

                        MessageBox.Show(@"Fingerprint image is of low quality.", Text, MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Extraction error");
            }
        }

        private void DefaultButtonClick(object sender, EventArgs e)
        {
            thresholdNumericUpDown.Value = 39;
            UseQuality();
        }

        private void SetButtonClick(object sender, EventArgs e)
        {
            UseQuality();
        }

        private void SaveImageButtonClick(object sender, EventArgs e)
        {
            if (nfView.Image == null) return;
            saveFileDialog.Filter = NImages.GetSaveFileFilterString();
            if (_oldImageFilename != string.Empty)
            {
                saveFileDialog.FileName = _oldImageFilename;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _oldImageFilename = saveFileDialog.FileName;

            string fileName = saveFileDialog.FileName;
            try
            {
                _grayscaleImage.Save(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error saving to file \"{0}\": {1}", fileName, ex),
                                Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UseQualityCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            UseQuality();
        }

        private void SaveTemplateButtonClick(object sender, EventArgs e)
        {
            if (_template == null) return;
            saveFileDialog.Filter = @"Template files (*.dat)|*.dat";
            if (_oldTemplateFilename != string.Empty)
            {
                saveFileDialog.FileName = _oldTemplateFilename;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            _oldTemplateFilename = saveFileDialog.FileName;

            // save template to file (*.dat)
            File.WriteAllBytes(saveFileDialog.FileName, _template.ToArray());
        }

        private void ThresholdNumericUpDownEnter(object sender, EventArgs e)
        {
            setButton.Enabled = true;
        }

        private void EnrollFromImageVisibleChanged(object sender, EventArgs e)
        {
            if (Visible && _extractor != null)
            {
                UseQuality();
            }
        }
    }
}
