namespace MultimodalBiometricsSystem.Face
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollFromImage));
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.facesView = new Neurotec.Biometrics.Gui.NLView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpenImage = new System.Windows.Forms.ToolStripButton();
            this.tlsLabel = new System.Windows.Forms.ToolStripLabel();
            this.cbRollAngle = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbYawAngle = new System.Windows.Forms.ToolStripComboBox();
            this.tsbExtract = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(11, 316);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(695, 20);
            this.tbStatus.TabIndex = 11;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveTemplate.Enabled = false;
            this.btnSaveTemplate.Location = new System.Drawing.Point(12, 342);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(105, 23);
            this.btnSaveTemplate.TabIndex = 10;
            this.btnSaveTemplate.Text = "&Save Template";
            this.btnSaveTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.BtnSaveTemplateClick);
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
            this.facesView.Location = new System.Drawing.Point(11, 26);
            this.facesView.Name = "facesView";
            this.facesView.Size = new System.Drawing.Size(695, 284);
            this.facesView.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenImage,
            this.tlsLabel,
            this.cbRollAngle,
            this.toolStripLabel1,
            this.cbYawAngle,
            this.tsbExtract});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 23);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpenImage
            // 
            this.tsbOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenImage.Name = "tsbOpenImage";
            this.tsbOpenImage.Size = new System.Drawing.Size(76, 19);
            this.tsbOpenImage.Text = "Open image";
            this.tsbOpenImage.ToolTipText = "Open image";
            this.tsbOpenImage.Click += new System.EventHandler(this.TsbOpenImageClick);
            // 
            // tlsLabel
            // 
            this.tlsLabel.Name = "tlsLabel";
            this.tlsLabel.Size = new System.Drawing.Size(136, 15);
            this.tlsLabel.Text = "Max roll angle deviation:";
            // 
            // cbRollAngle
            // 
            this.cbRollAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRollAngle.Name = "cbRollAngle";
            this.cbRollAngle.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 15);
            this.toolStripLabel1.Text = "Max yaw angle deviation:";
            // 
            // cbYawAngle
            // 
            this.cbYawAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYawAngle.Name = "cbYawAngle";
            this.cbYawAngle.Size = new System.Drawing.Size(121, 23);
            // 
            // tsbExtract
            // 
            this.tsbExtract.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExtract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbExtract.Image = ((System.Drawing.Image)(resources.GetObject("tsbExtract.Image")));
            this.tsbExtract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExtract.Name = "tsbExtract";
            this.tsbExtract.Size = new System.Drawing.Size(105, 19);
            this.tsbExtract.Text = "Extract template";
            this.tsbExtract.Click += new System.EventHandler(this.TsbExtractClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // EnrollFromImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 377);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.facesView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnrollFromImage";
            this.Text = "Enroll Face From Image";
            this.Load += new System.EventHandler(this.EnrollFromImageLoad);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btnSaveTemplate;
        private Neurotec.Biometrics.Gui.NLView facesView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpenImage;
        private System.Windows.Forms.ToolStripLabel tlsLabel;
        private System.Windows.Forms.ToolStripComboBox cbRollAngle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbYawAngle;
        private System.Windows.Forms.ToolStripButton tsbExtract;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}