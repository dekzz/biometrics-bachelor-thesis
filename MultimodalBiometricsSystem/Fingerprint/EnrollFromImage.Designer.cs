namespace MultimodalBiometricsSystem.Fingerprint
{
    partial class EnrollFromImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollFromImage));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new Neurotec.Biometrics.Gui.NFView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.setButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.extractFeaturesButton = new System.Windows.Forms.Button();
            this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UseQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.nfView = new Neurotec.Biometrics.Gui.NFView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuality = new System.Windows.Forms.Label();
            this.saveTemplateButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.imagePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.imagePanel);
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.nfView);
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(423, 405);
            this.splitContainer.SplitterDistance = 201;
            this.splitContainer.TabIndex = 14;
            // 
            // imagePanel
            // 
            this.imagePanel.AutoScroll = true;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(423, 133);
            this.imagePanel.TabIndex = 5;
            // 
            // pictureBox
            // 
            this.pictureBox.AutoScroll = true;
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.MinutiaColor = System.Drawing.Color.Red;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.NeighborMinutiaColor = System.Drawing.Color.Orange;
            this.pictureBox.SelectedMinutiaColor = System.Drawing.Color.Magenta;
            this.pictureBox.SelectedSingularPointColor = System.Drawing.Color.Magenta;
            this.pictureBox.SingularPointColor = System.Drawing.Color.Red;
            this.pictureBox.Size = new System.Drawing.Size(419, 129);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TreeColor = System.Drawing.Color.Crimson;
            this.pictureBox.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
            this.pictureBox.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
            this.pictureBox.TreeWidth = 2D;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.setButton);
            this.panel2.Controls.Add(this.openButton);
            this.panel2.Controls.Add(this.defaultButton);
            this.panel2.Controls.Add(this.extractFeaturesButton);
            this.panel2.Controls.Add(this.thresholdNumericUpDown);
            this.panel2.Controls.Add(this.UseQualityCheckBox);
            this.panel2.Controls.Add(this.ThresholdLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 68);
            this.panel2.TabIndex = 11;
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.Enabled = false;
            this.setButton.Location = new System.Drawing.Point(355, 39);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(62, 23);
            this.setButton.TabIndex = 11;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.SetButtonClick);
            // 
            // openButton
            // 
            this.openButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.Location = new System.Drawing.Point(8, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(93, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Tag = "Open";
            this.openButton.Text = "Open Image";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // defaultButton
            // 
            this.defaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultButton.Enabled = false;
            this.defaultButton.Location = new System.Drawing.Point(355, 12);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(62, 23);
            this.defaultButton.TabIndex = 10;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.DefaultButtonClick);
            // 
            // extractFeaturesButton
            // 
            this.extractFeaturesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.extractFeaturesButton.Location = new System.Drawing.Point(110, 12);
            this.extractFeaturesButton.Name = "extractFeaturesButton";
            this.extractFeaturesButton.Size = new System.Drawing.Size(106, 23);
            this.extractFeaturesButton.TabIndex = 2;
            this.extractFeaturesButton.Text = "&Extract Features";
            this.extractFeaturesButton.UseVisualStyleBackColor = true;
            this.extractFeaturesButton.Click += new System.EventHandler(this.ExtractFeaturesButtonClick);
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(301, 41);
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.thresholdNumericUpDown.TabIndex = 9;
            this.thresholdNumericUpDown.Value = new decimal(new int[] {
            39,
            0,
            0,
            0});
            this.thresholdNumericUpDown.Enter += new System.EventHandler(this.ThresholdNumericUpDownEnter);
            // 
            // UseQualityCheckBox
            // 
            this.UseQualityCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseQualityCheckBox.AutoSize = true;
            this.UseQualityCheckBox.Checked = true;
            this.UseQualityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseQualityCheckBox.Location = new System.Drawing.Point(241, 18);
            this.UseQualityCheckBox.Name = "UseQualityCheckBox";
            this.UseQualityCheckBox.Size = new System.Drawing.Size(80, 17);
            this.UseQualityCheckBox.TabIndex = 7;
            this.UseQualityCheckBox.Text = "Use Quality";
            this.UseQualityCheckBox.UseVisualStyleBackColor = true;
            this.UseQualityCheckBox.CheckedChanged += new System.EventHandler(this.UseQualityCheckBoxCheckedChanged);
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(238, 44);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.ThresholdLabel.TabIndex = 8;
            this.ThresholdLabel.Text = "Threshold:";
            // 
            // nfView
            // 
            this.nfView.AutoScroll = true;
            this.nfView.BackColor = System.Drawing.SystemColors.Control;
            this.nfView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nfView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nfView.Location = new System.Drawing.Point(0, 0);
            this.nfView.MinutiaColor = System.Drawing.Color.Red;
            this.nfView.Name = "nfView";
            this.nfView.NeighborMinutiaColor = System.Drawing.Color.Orange;
            this.nfView.SelectedMinutiaColor = System.Drawing.Color.Magenta;
            this.nfView.SelectedSingularPointColor = System.Drawing.Color.Magenta;
            this.nfView.SingularPointColor = System.Drawing.Color.Red;
            this.nfView.Size = new System.Drawing.Size(423, 156);
            this.nfView.TabIndex = 4;
            this.nfView.TreeColor = System.Drawing.Color.Crimson;
            this.nfView.TreeMinutiaNumberDiplayFormat = Neurotec.Biometrics.Gui.MinutiaNumberDiplayFormat.DontDisplay;
            this.nfView.TreeMinutiaNumberFont = new System.Drawing.Font("Arial", 10F);
            this.nfView.TreeWidth = 2D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblQuality);
            this.panel1.Controls.Add(this.saveTemplateButton);
            this.panel1.Controls.Add(this.saveImageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblQuality
            // 
            this.lblQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuality.Location = new System.Drawing.Point(241, 11);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(170, 23);
            this.lblQuality.TabIndex = 1;
            // 
            // saveTemplateButton
            // 
            this.saveTemplateButton.Location = new System.Drawing.Point(110, 11);
            this.saveTemplateButton.Name = "saveTemplateButton";
            this.saveTemplateButton.Size = new System.Drawing.Size(96, 23);
            this.saveTemplateButton.TabIndex = 6;
            this.saveTemplateButton.Text = "&Save Template";
            this.saveTemplateButton.UseVisualStyleBackColor = true;
            this.saveTemplateButton.Click += new System.EventHandler(this.SaveTemplateButtonClick);
            // 
            // saveImageButton
            // 
            this.saveImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveImageButton.Location = new System.Drawing.Point(8, 11);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(96, 23);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.SaveImageButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // EnrollFromImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 429);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnrollFromImage";
            this.Text = "Enroll Fingerprint From Image";
            this.VisibleChanged += new System.EventHandler(this.EnrollFromImageVisibleChanged);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel imagePanel;
        private Neurotec.Biometrics.Gui.NFView pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button extractFeaturesButton;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.CheckBox UseQualityCheckBox;
        private System.Windows.Forms.Label ThresholdLabel;
        private Neurotec.Biometrics.Gui.NFView nfView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Button saveTemplateButton;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}