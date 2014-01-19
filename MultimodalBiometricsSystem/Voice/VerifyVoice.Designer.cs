namespace MultimodalBiometricsSystem.Voice
{
    partial class VerifyVoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyVoice));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbMatching = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.matchingFarLabel = new System.Windows.Forms.Label();
            this.cbMatchingFAR = new System.Windows.Forms.ComboBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.lblSecondTemplate = new System.Windows.Forms.Label();
            this.lblFirstTemplate = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.gbMatching.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // gbMatching
            // 
            this.gbMatching.Controls.Add(this.btnSet);
            this.gbMatching.Controls.Add(this.btnDefault);
            this.gbMatching.Controls.Add(this.matchingFarLabel);
            this.gbMatching.Controls.Add(this.cbMatchingFAR);
            this.gbMatching.Location = new System.Drawing.Point(12, 12);
            this.gbMatching.MaximumSize = new System.Drawing.Size(600, 200);
            this.gbMatching.Name = "gbMatching";
            this.gbMatching.Size = new System.Drawing.Size(194, 54);
            this.gbMatching.TabIndex = 53;
            this.gbMatching.TabStop = false;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(71, 26);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(51, 23);
            this.btnSet.TabIndex = 21;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSetClick);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefault.Location = new System.Drawing.Point(125, 26);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(63, 23);
            this.btnDefault.TabIndex = 20;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefaultClick);
            // 
            // matchingFarLabel
            // 
            this.matchingFarLabel.AutoSize = true;
            this.matchingFarLabel.Location = new System.Drawing.Point(11, 10);
            this.matchingFarLabel.Name = "matchingFarLabel";
            this.matchingFarLabel.Size = new System.Drawing.Size(78, 13);
            this.matchingFarLabel.TabIndex = 18;
            this.matchingFarLabel.Text = "Matching &FAR:";
            // 
            // cbMatchingFAR
            // 
            this.cbMatchingFAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMatchingFAR.FormattingEnabled = true;
            this.cbMatchingFAR.Location = new System.Drawing.Point(9, 28);
            this.cbMatchingFAR.Name = "cbMatchingFAR";
            this.cbMatchingFAR.Size = new System.Drawing.Size(56, 21);
            this.cbMatchingFAR.TabIndex = 19;
            this.cbMatchingFAR.Enter += new System.EventHandler(this.CbMatchingFAREnter);
            // 
            // btnOpen2
            // 
            this.btnOpen2.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen2.Image")));
            this.btnOpen2.Location = new System.Drawing.Point(12, 105);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(30, 23);
            this.btnOpen2.TabIndex = 52;
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.BtnOpen2Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen1.Image")));
            this.btnOpen1.Location = new System.Drawing.Point(12, 76);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(30, 23);
            this.btnOpen1.TabIndex = 51;
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.BtnOpen1Click);
            // 
            // lblSecondTemplate
            // 
            this.lblSecondTemplate.AutoSize = true;
            this.lblSecondTemplate.Location = new System.Drawing.Point(201, 110);
            this.lblSecondTemplate.Name = "lblSecondTemplate";
            this.lblSecondTemplate.Size = new System.Drawing.Size(85, 13);
            this.lblSecondTemplate.TabIndex = 59;
            this.lblSecondTemplate.Text = "second template";
            // 
            // lblFirstTemplate
            // 
            this.lblFirstTemplate.AutoSize = true;
            this.lblFirstTemplate.Location = new System.Drawing.Point(201, 81);
            this.lblFirstTemplate.Name = "lblFirstTemplate";
            this.lblFirstTemplate.Size = new System.Drawing.Size(66, 13);
            this.lblFirstTemplate.TabIndex = 58;
            this.lblFirstTemplate.Text = "first template";
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(12, 139);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(121, 23);
            this.btnVerify.TabIndex = 55;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.BtnVerifyClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Second template or audio file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "First template or audio file:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(144, 144);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(33, 13);
            this.lblMsg.TabIndex = 54;
            this.lblMsg.Text = "score";
            // 
            // VerifyVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 170);
            this.Controls.Add(this.gbMatching);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Controls.Add(this.lblSecondTemplate);
            this.Controls.Add(this.lblFirstTemplate);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerifyVoice";
            this.Text = "Verify Voice";
            this.Load += new System.EventHandler(this.VerifyVoiceLoad);
            this.gbMatching.ResumeLayout(false);
            this.gbMatching.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox gbMatching;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label matchingFarLabel;
        private System.Windows.Forms.ComboBox cbMatchingFAR;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Label lblSecondTemplate;
        private System.Windows.Forms.Label lblFirstTemplate;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
    }
}