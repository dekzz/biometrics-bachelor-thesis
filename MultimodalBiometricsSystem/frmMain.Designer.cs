namespace MultimodalBiometricsSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnVerification = new System.Windows.Forms.Button();
            this.btnIdentification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.Location = new System.Drawing.Point(53, 28);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(138, 33);
            this.btnEnrollment.TabIndex = 0;
            this.btnEnrollment.Text = "Enrollment";
            this.btnEnrollment.UseVisualStyleBackColor = true;
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // btnVerification
            // 
            this.btnVerification.Location = new System.Drawing.Point(53, 78);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(138, 33);
            this.btnVerification.TabIndex = 1;
            this.btnVerification.Text = "Verification";
            this.btnVerification.UseVisualStyleBackColor = true;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // btnIdentification
            // 
            this.btnIdentification.Location = new System.Drawing.Point(53, 126);
            this.btnIdentification.Name = "btnIdentification";
            this.btnIdentification.Size = new System.Drawing.Size(138, 33);
            this.btnIdentification.TabIndex = 2;
            this.btnIdentification.Text = "Identification";
            this.btnIdentification.UseVisualStyleBackColor = true;
            this.btnIdentification.Click += new System.EventHandler(this.btnIdentification_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 191);
            this.Controls.Add(this.btnIdentification);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.btnEnrollment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Multimodal Biometrics System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnVerification;
        private System.Windows.Forms.Button btnIdentification;
    }
}

