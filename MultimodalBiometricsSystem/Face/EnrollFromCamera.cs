using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Devices;
using Neurotec.Images;
using Neurotec.IO;

namespace MultimodalBiometricsSystem.Face
{
    public partial class EnrollFromCamera : Form
    {
        public EnrollFromCamera()
        {
            InitializeComponent();
        }

        private readonly List<NImage> _capturedImages = new List<NImage>();

		private NLExtractor _extractor;
		private NImage _bestFrame;
		private NDeviceManager _deviceManager;
		private NCamera _camera;
		private NBuffer _template;
		private bool _capture;

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

		private void UpdateCameraList()
		{
			cbxCameras.BeginUpdate();
			try
			{
				cbxCameras.Items.Clear();
				_deviceManager.Refresh();
				foreach (NDevice device in _deviceManager.Devices)
				{
					cbxCameras.Items.Add(device);
				}

				if (_camera != null && _camera.IsDisposed) _camera = null;

				if (_camera == null && cbxCameras.Items.Count > 0)
				{
					cbxCameras.SelectedIndex = 0;
					return;
				}

				if (_camera != null)
				{
					cbxCameras.SelectedIndex = cbxCameras.Items.IndexOf(_camera);
				}
			}
			finally
			{
				cbxCameras.EndUpdate();
			}
		}

		private void EnableControls(bool capturing)
		{
			btnStartCapturing.Enabled = !capturing;
			btnRefreshCamera.Enabled = !capturing;
			btnStopCapturing.Enabled = capturing;
			cbxCameras.Enabled = !capturing;
			gbxFrames.Enabled = !capturing;
			btnSaveImage.Enabled = !capturing && _bestFrame != null;
			btnSaveTemplate.Enabled = !capturing && _template != null;
			btnStartExtraction.Enabled = capturing;
		}

		private void ClearCapturedImages()
		{
			for (int i = 0; i < _capturedImages.Count; i++)
			{
				_capturedImages[i].Dispose();
			}
			_capturedImages.Clear();
		}

		private delegate void UpdateViewDelegate(Bitmap image, NleDetectionDetails[] details, NleExtractionStatus status);
		private void UpdateView(Bitmap image, NleDetectionDetails[] details, NleExtractionStatus status)
		{
			if (InvokeRequired)
			{
				UpdateViewDelegate del = UpdateView;
				BeginInvoke(del, image, details, status);
				return;
			}

			Image oldImage = facesView.Image;
			if (oldImage != null) oldImage.Dispose();
			facesView.Image = image;
			facesView.DetectionDetails = details;

			if (status != NleExtractionStatus.None)
			{
				lblStatus.Text = status.ToString();
			}
			else if (_capture)
			{
				lblStatus.Text = @"Extracting ...";
			}
		}

		private void EnrollFromCameraLoad(object sender, EventArgs e)
		{
			try
			{
				lblStatus.Text = string.Empty;
				_deviceManager = new NDeviceManager(NDeviceType.Camera, true, false);
				saveImageDialog.Filter = NImages.GetSaveFileFilterString();
				UpdateCameraList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnRefreshCameraClick(object sender, EventArgs e)
		{
			UpdateCameraList();
		}

		private void cbxCamerasSelectedIndexChanged(object sender, EventArgs e)
		{
			_camera = cbxCameras.SelectedItem as NCamera;
		}

		private void btnStartCapturingClick(object sender, EventArgs e)
		{
			if (_camera == null)
			{
				MessageBox.Show(@"Please select camera from the list");
				return;
			}

			_template = null;
			if (_bestFrame != null)
			{
				_bestFrame.Dispose();
				_bestFrame = null;
			}
			_extractor.MaxStreamDurationInFrames = Convert.ToInt32(nudFrames.Value);
			_extractor.DetectAllFeaturePoints = false;
			lblStatus.Text = string.Empty;
			backgroundWorker.RunWorkerAsync();
			EnableControls(true);
		}

		private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
		{
			bool extractStarted = false;
			try
			{
				_camera.StartCapturing();
				_capture = false;

				while (true)
				{
					using (NImage frame = _camera.GetFrame())
					{
						if (frame == null || backgroundWorker.CancellationPending)
						{
							UpdateView(null, null, NleExtractionStatus.None);
							return;
						}
						using (NGrayscaleImage grayscaleImage = frame.ToGrayscale())
						{
							if (!_capture)
							{
								NleFace[] faces = _extractor.DetectFaces(grayscaleImage);
								NleDetectionDetails[] details = new NleDetectionDetails[faces.Length];
								for (int i = 0; i < details.Length; i++)
								{
									details[i] = _extractor.DetectFacialFeatures(grayscaleImage, faces[i]);
								}
								UpdateView(frame.ToBitmap(), details, NleExtractionStatus.None);
							}
							else
							{
								if (!extractStarted)
								{
									_extractor.ExtractStart();
									extractStarted = true;
								}

								NleDetectionDetails details;
								NleExtractionStatus status = _extractor.ExtractNext(grayscaleImage, out details);
								_capturedImages.Add((NImage)frame.Clone());
								if (status != NleExtractionStatus.None)
								{
									int frameIndex;
									NLTemplate template = _extractor.ExtractEnd(out frameIndex, out status);
									extractStarted = false;
									_capture = false;
									if (status == NleExtractionStatus.TemplateCreated)
									{
										_template = template.Save();
										template.Dispose();
										_bestFrame = (NImage)_capturedImages[frameIndex].Clone();
										UpdateView(_bestFrame.ToBitmap(), new NleDetectionDetails[] { details }, status);
										ClearCapturedImages();
										return;
									}
									ClearCapturedImages();
									UpdateView(frame.ToBitmap(), null, status);
									continue;
								}
								UpdateView(frame.ToBitmap(), new NleDetectionDetails[] { details }, status);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				if (extractStarted)
				{
					int baseFrameIndex;
					NleExtractionStatus status;
					_extractor.ExtractEnd(out baseFrameIndex, out status);
				}
				if (_camera != null) _camera.StopCapturing();
			}
		}

		private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			EnableControls(false);
			UpdateCameraList();
		}

		private void btnStopCapturingClick(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

		private void BtnDefaultClick(object sender, EventArgs e)
		{
			nudFrames.Value = 10;
		}

		private void BtnSaveTemplateClick(object sender, EventArgs e)
		{
			if (_template != null && saveTemplateDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllBytes(saveTemplateDialog.FileName, _template.ToArray());
			}
		}

		private void btnStartExtractionClick(object sender, EventArgs e)
		{
			lblStatus.Text = string.Empty;
			_capture = true;
		}

		private void BtnSaveImageClick(object sender, EventArgs e)
		{
			if (_bestFrame != null && saveImageDialog.ShowDialog() == DialogResult.OK)
			{
				_bestFrame.Save(saveImageDialog.FileName);
			}
		}

        /*
		public override void CancelWork()
		{
			if (!backgroundWorker.IsBusy) return;

			backgroundWorker.CancelAsync();
			while (backgroundWorker.IsBusy)
			{
				Application.DoEvents();
			}
         }
         */
	}
}
