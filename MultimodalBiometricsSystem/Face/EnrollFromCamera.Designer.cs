namespace MultimodalBiometricsSystem.Face
{
    partial class EnrollFromCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollFromCamera));
            this.gbxCamera = new System.Windows.Forms.GroupBox();
            this.btnStopCapturing = new System.Windows.Forms.Button();
            this.btnStartCapturing = new System.Windows.Forms.Button();
            this.btnRefreshCamera = new System.Windows.Forms.Button();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.gbxFrames = new System.Windows.Forms.GroupBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.nudFrames = new System.Windows.Forms.NumericUpDown();
            this.btnStartExtraction = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.facesView = new Neurotec.Biometrics.Gui.NLView();
            this.saveTemplateDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.gbxCamera.SuspendLayout();
            this.gbxFrames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrames)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCamera
            // 
            this.gbxCamera.Controls.Add(this.btnStopCapturing);
            this.gbxCamera.Controls.Add(this.btnStartCapturing);
            this.gbxCamera.Controls.Add(this.btnRefreshCamera);
            this.gbxCamera.Controls.Add(this.cbxCameras);
            this.gbxCamera.Location = new System.Drawing.Point(12, 12);
            this.gbxCamera.Name = "gbxCamera";
            this.gbxCamera.Size = new System.Drawing.Size(505, 74);
            this.gbxCamera.TabIndex = 0;
            this.gbxCamera.TabStop = false;
            this.gbxCamera.Text = "Camera";
            // 
            // btnStopCapturing
            // 
            this.btnStopCapturing.Enabled = false;
            this.btnStopCapturing.Location = new System.Drawing.Point(198, 45);
            this.btnStopCapturing.Name = "btnStopCapturing";
            this.btnStopCapturing.Size = new System.Drawing.Size(96, 23);
            this.btnStopCapturing.TabIndex = 19;
            this.btnStopCapturing.Text = "Stop Capturing";
            this.btnStopCapturing.UseVisualStyleBackColor = true;
            this.btnStopCapturing.Click += new System.EventHandler(this.btnStopCapturingClick);
            // 
            // btnStartCapturing
            // 
            this.btnStartCapturing.Location = new System.Drawing.Point(99, 45);
            this.btnStartCapturing.Name = "btnStartCapturing";
            this.btnStartCapturing.Size = new System.Drawing.Size(93, 23);
            this.btnStartCapturing.TabIndex = 18;
            this.btnStartCapturing.Text = "Start Capturing";
            this.btnStartCapturing.UseVisualStyleBackColor = true;
            this.btnStartCapturing.Click += new System.EventHandler(this.btnStartCapturingClick);
            // 
            // btnRefreshCamera
            // 
            this.btnRefreshCamera.Location = new System.Drawing.Point(7, 45);
            this.btnRefreshCamera.Name = "btnRefreshCamera";
            this.btnRefreshCamera.Size = new System.Drawing.Size(86, 23);
            this.btnRefreshCamera.TabIndex = 1;
            this.btnRefreshCamera.Text = "Refresh List";
            this.btnRefreshCamera.UseVisualStyleBackColor = true;
            this.btnRefreshCamera.Click += new System.EventHandler(this.btnRefreshCameraClick);
            // 
            // cbxCameras
            // 
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(7, 20);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(492, 21);
            this.cbxCameras.TabIndex = 15;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCamerasSelectedIndexChanged);
            // 
            // gbxFrames
            // 
            this.gbxFrames.Controls.Add(this.btnDefault);
            this.gbxFrames.Controls.Add(this.nudFrames);
            this.gbxFrames.Location = new System.Drawing.Point(535, 12);
            this.gbxFrames.Name = "gbxFrames";
            this.gbxFrames.Size = new System.Drawing.Size(155, 74);
            this.gbxFrames.TabIndex = 1;
            this.gbxFrames.TabStop = false;
            this.gbxFrames.Text = "Stream duration in frames";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(6, 45);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(89, 23);
            this.btnDefault.TabIndex = 1;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefaultClick);
            // 
            // nudFrames
            // 
            this.nudFrames.Location = new System.Drawing.Point(6, 19);
            this.nudFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrames.Name = "nudFrames";
            this.nudFrames.Size = new System.Drawing.Size(143, 20);
            this.nudFrames.TabIndex = 0;
            this.nudFrames.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnStartExtraction
            // 
            this.btnStartExtraction.Enabled = false;
            this.btnStartExtraction.Location = new System.Drawing.Point(19, 432);
            this.btnStartExtraction.Name = "btnStartExtraction";
            this.btnStartExtraction.Size = new System.Drawing.Size(102, 23);
            this.btnStartExtraction.TabIndex = 23;
            this.btnStartExtraction.Text = "Start Extraction";
            this.btnStartExtraction.UseVisualStyleBackColor = true;
            this.btnStartExtraction.Click += new System.EventHandler(this.btnStartExtractionClick);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Location = new System.Drawing.Point(617, 432);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 3;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.BtnSaveImageClick);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Enabled = false;
            this.btnSaveTemplate.Location = new System.Drawing.Point(522, 432);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(88, 23);
            this.btnSaveTemplate.TabIndex = 9;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.BtnSaveTemplateClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(138, 437);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // facesView
            // 
            this.facesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.facesView.AutoScroll = true;
            this.facesView.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.facesView.DetectionDetails = null;
            this.facesView.FaceIds = null;
            this.facesView.Image = null;
            this.facesView.Location = new System.Drawing.Point(12, 92);
            this.facesView.Name = "facesView";
            this.facesView.Size = new System.Drawing.Size(678, 334);
            this.facesView.TabIndex = 13;
            // 
            // EnrollFromCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 467);
            this.Controls.Add(this.facesView);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnStartExtraction);
            this.Controls.Add(this.gbxFrames);
            this.Controls.Add(this.gbxCamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnrollFromCamera";
            this.Text = "Enroll From Camera";
            this.Load += new System.EventHandler(this.EnrollFromCameraLoad);
            this.gbxCamera.ResumeLayout(false);
            this.gbxFrames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFrames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCamera;
        private System.Windows.Forms.Button btnStopCapturing;
        private System.Windows.Forms.Button btnStartCapturing;
        private System.Windows.Forms.Button btnRefreshCamera;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.GroupBox gbxFrames;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.NumericUpDown nudFrames;
        private System.Windows.Forms.Button btnStartExtraction;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Label lblStatus;
        private Neurotec.Biometrics.Gui.NLView facesView;
        private System.Windows.Forms.SaveFileDialog saveTemplateDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}