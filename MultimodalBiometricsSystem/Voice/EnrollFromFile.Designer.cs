namespace MultimodalBiometricsSystem.Voice
{
    partial class EnrollFromFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollFromFile));
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPauseDuration = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPhraseDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chbAutoDetect = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPhraseId = new System.Windows.Forms.NumericUpDown();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.lblSoundFile = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPhraseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhraseId)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sound File:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblStatus.Location = new System.Drawing.Point(9, 158);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Extraction Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudPauseDuration);
            this.groupBox1.Controls.Add(this.nudMaxPhraseDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chbAutoDetect);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 85);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Max Phrase Duration:";
            // 
            // nudPauseDuration
            // 
            this.nudPauseDuration.DecimalPlaces = 1;
            this.nudPauseDuration.Location = new System.Drawing.Point(113, 58);
            this.nudPauseDuration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPauseDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPauseDuration.Name = "nudPauseDuration";
            this.nudPauseDuration.Size = new System.Drawing.Size(59, 20);
            this.nudPauseDuration.TabIndex = 13;
            this.nudPauseDuration.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudMaxPhraseDuration
            // 
            this.nudMaxPhraseDuration.DecimalPlaces = 1;
            this.nudMaxPhraseDuration.Location = new System.Drawing.Point(121, 14);
            this.nudMaxPhraseDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxPhraseDuration.Name = "nudMaxPhraseDuration";
            this.nudMaxPhraseDuration.Size = new System.Drawing.Size(78, 20);
            this.nudMaxPhraseDuration.TabIndex = 14;
            this.nudMaxPhraseDuration.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pause duration:";
            // 
            // chbAutoDetect
            // 
            this.chbAutoDetect.AutoSize = true;
            this.chbAutoDetect.Checked = true;
            this.chbAutoDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoDetect.Location = new System.Drawing.Point(9, 40);
            this.chbAutoDetect.Name = "chbAutoDetect";
            this.chbAutoDetect.Size = new System.Drawing.Size(179, 17);
            this.chbAutoDetect.TabIndex = 11;
            this.chbAutoDetect.Text = "Auto detect end of voice activity";
            this.chbAutoDetect.UseVisualStyleBackColor = true;
            this.chbAutoDetect.CheckedChanged += new System.EventHandler(this.ChbAutoDetectCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Phrase Id:";
            // 
            // nudPhraseId
            // 
            this.nudPhraseId.Location = new System.Drawing.Point(183, 135);
            this.nudPhraseId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPhraseId.Name = "nudPhraseId";
            this.nudPhraseId.Size = new System.Drawing.Size(93, 20);
            this.nudPhraseId.TabIndex = 22;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(12, 132);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(101, 23);
            this.btnExtract.TabIndex = 21;
            this.btnExtract.Text = "&Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.BtnExtractClick);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTemplate.Location = new System.Drawing.Point(12, 177);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(101, 23);
            this.btnSaveTemplate.TabIndex = 20;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.BtnSaveTemplateClick);
            // 
            // lblSoundFile
            // 
            this.lblSoundFile.AutoSize = true;
            this.lblSoundFile.Location = new System.Drawing.Point(177, 17);
            this.lblSoundFile.Name = "lblSoundFile";
            this.lblSoundFile.Size = new System.Drawing.Size(94, 13);
            this.lblSoundFile.TabIndex = 19;
            this.lblSoundFile.Text = "Sound file location";
            // 
            // btnOpen
            // 
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(93, 23);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Tag = "Open";
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // EnrollFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 212);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPhraseId);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.lblSoundFile);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnrollFromFile";
            this.Text = "Enroll Voice From File";
            this.Load += new System.EventHandler(this.EnrollFromFileLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPhraseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhraseId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPauseDuration;
        private System.Windows.Forms.NumericUpDown nudMaxPhraseDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbAutoDetect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPhraseId;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Label lblSoundFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}