namespace MultimodalBiometricsSystem
{
    partial class frmBiometrics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiometrics));
            this.btnGo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.radFingerprint = new System.Windows.Forms.RadioButton();
            this.radFace = new System.Windows.Forms.RadioButton();
            this.radVoice = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(113, 176);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 207);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(200, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // radFingerprint
            // 
            this.radFingerprint.AutoSize = true;
            this.radFingerprint.Location = new System.Drawing.Point(54, 39);
            this.radFingerprint.Name = "radFingerprint";
            this.radFingerprint.Size = new System.Drawing.Size(74, 17);
            this.radFingerprint.TabIndex = 5;
            this.radFingerprint.TabStop = true;
            this.radFingerprint.Text = "Fingerprint";
            this.radFingerprint.UseVisualStyleBackColor = true;
            // 
            // radFace
            // 
            this.radFace.AutoSize = true;
            this.radFace.Location = new System.Drawing.Point(54, 83);
            this.radFace.Name = "radFace";
            this.radFace.Size = new System.Drawing.Size(49, 17);
            this.radFace.TabIndex = 6;
            this.radFace.TabStop = true;
            this.radFace.Text = "Face";
            this.radFace.UseVisualStyleBackColor = true;
            // 
            // radVoice
            // 
            this.radVoice.AutoSize = true;
            this.radVoice.Location = new System.Drawing.Point(54, 125);
            this.radVoice.Name = "radVoice";
            this.radVoice.Size = new System.Drawing.Size(52, 17);
            this.radVoice.TabIndex = 7;
            this.radVoice.TabStop = true;
            this.radVoice.Text = "Voice";
            this.radVoice.UseVisualStyleBackColor = true;
            // 
            // frmBiometrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 229);
            this.Controls.Add(this.radVoice);
            this.Controls.Add(this.radFace);
            this.Controls.Add(this.radFingerprint);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBiometrics";
            this.Text = "Choose Biometrics";
            this.Load += new System.EventHandler(this.frmBiometrics_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.RadioButton radFingerprint;
        private System.Windows.Forms.RadioButton radFace;
        private System.Windows.Forms.RadioButton radVoice;
    }
}