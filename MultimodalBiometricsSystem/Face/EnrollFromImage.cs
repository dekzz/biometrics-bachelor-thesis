using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Images;

namespace MultimodalBiometricsSystem.Face
{
    public partial class EnrollFromImage : Form
    {
        public EnrollFromImage()
        {
            InitializeComponent();
        }

        private NLExtractor _extractor;
		private NImage _image;
		private NLTemplate _template;

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

		private void ExtractTemplate()
		{
			if (_image == null) return;

			if (_template != null)
			{
				_template.Dispose();
				_template = null;
			}

			_extractor.DetectAllFeaturePoints = true;
			_extractor.MaxRollAngleDeviation = (short)cbRollAngle.SelectedItem;
			_extractor.MaxYawAngleDeviation = (short)cbYawAngle.SelectedItem;

			using (NGrayscaleImage grayscaleImage = _image.ToGrayscale())
			{
				NleExtractionStatus status;
				NleDetectionDetails details;
				_template = _extractor.Extract(grayscaleImage, out details, out status);
				if (status == NleExtractionStatus.TemplateCreated)
				{
					facesView.DetectionDetails = new NleDetectionDetails[] { details };
					tbStatus.Text = @"Template extracted";
					btnSaveTemplate.Enabled = true;
				}
				else
				{
					tbStatus.Text = string.Format("Extraction failed: {0}", status);
					btnSaveTemplate.Enabled = false;
					facesView.DetectionDetails = null;
				}
			}
		}

		private void EnrollFromImageLoad(object sender, EventArgs e)
		{
			try
			{
				short item = _extractor.MaxRollAngleDeviation;
				List<short> items = new List<short>();
				for (short i = 15; i <= 180; i += 15)
				{
					items.Add((i));
				}
				if (!items.Contains(item))
					items.Add(item);
				items.Sort();

				int index = items.IndexOf(item);
				for (int i = 0; i != items.Count; i++)
				{
					cbRollAngle.Items.Add(items[i]);
				}
				cbRollAngle.SelectedIndex = index;

				item = _extractor.MaxYawAngleDeviation;
				items.Clear();
				for (short i = 15; i <= 90; i += 15)
				{
					items.Add((i));
				}
				if (!items.Contains(item))
					items.Add(item);
				items.Sort();

				index = items.IndexOf(item);
				for (int i = 0; i != items.Count; i++)
				{
					cbYawAngle.Items.Add(items[i]);
				}
				cbYawAngle.SelectedIndex = index;

				openFileDialog.Filter = NImages.GetOpenFileFilterString(true, true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void BtnSaveTemplateClick(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.WriteAllBytes(saveFileDialog.FileName, _template.Save().ToArray());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		private void TsbExtractClick(object sender, EventArgs e)
		{
			try
			{
				ExtractTemplate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				btnSaveTemplate.Enabled = false;
			}
		}

		private void TsbOpenImageClick(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					_image = NImage.FromFile(openFileDialog.FileName);
					facesView.Image = _image.ToBitmap();
					facesView.DetectionDetails = null;
					ExtractTemplate();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				btnSaveTemplate.Enabled = false;
			}
		}
	}
}