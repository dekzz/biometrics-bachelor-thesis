namespace MultimodalBiometricsSystem.Voice
{
    partial class EnrollFromMicrophone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollFromMicrophone));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbMicrophones = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbMicrophones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPhraseId = new System.Windows.Forms.NumericUpDown();
            this.nudPauseDuration = new System.Windows.Forms.NumericUpDown();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMaxPhraseDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chbAutoDetect = new System.Windows.Forms.CheckBox();
            this.pbSoundLevel = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbMicrophones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhraseId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).BeginInit();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPhraseDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(168, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // gbMicrophones
            // 
            this.gbMicrophones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMicrophones.Controls.Add(this.btnStop);
            this.gbMicrophones.Controls.Add(this.btnRefresh);
            this.gbMicrophones.Controls.Add(this.btnStart);
            this.gbMicrophones.Controls.Add(this.lbMicrophones);
            this.gbMicrophones.Location = new System.Drawing.Point(12, 12);
            this.gbMicrophones.Name = "gbMicrophones";
            this.gbMicrophones.Size = new System.Drawing.Size(439, 115);
            this.gbMicrophones.TabIndex = 14;
            this.gbMicrophones.TabStop = false;
            this.gbMicrophones.Text = "Microphones list";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(87, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStopClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // lbMicrophones
            // 
            this.lbMicrophones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMicrophones.Location = new System.Drawing.Point(4, 19);
            this.lbMicrophones.Name = "lbMicrophones";
            this.lbMicrophones.Size = new System.Drawing.Size(429, 56);
            this.lbMicrophones.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phrase Id:";
            // 
            // nudPhraseId
            // 
            this.nudPhraseId.Location = new System.Drawing.Point(67, 84);
            this.nudPhraseId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPhraseId.Name = "nudPhraseId";
            this.nudPhraseId.Size = new System.Drawing.Size(93, 20);
            this.nudPhraseId.TabIndex = 18;
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
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.label4);
            this.gbOptions.Controls.Add(this.label3);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.nudPhraseId);
            this.gbOptions.Controls.Add(this.nudPauseDuration);
            this.gbOptions.Controls.Add(this.nudMaxPhraseDuration);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Controls.Add(this.chbAutoDetect);
            this.gbOptions.Location = new System.Drawing.Point(12, 133);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(439, 115);
            this.gbOptions.TabIndex = 21;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
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
            // 
            // pbSoundLevel
            // 
            this.pbSoundLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSoundLevel.Location = new System.Drawing.Point(91, 256);
            this.pbSoundLevel.Name = "pbSoundLevel";
            this.pbSoundLevel.Size = new System.Drawing.Size(360, 16);
            this.pbSoundLevel.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sound level:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblStatus.Location = new System.Drawing.Point(15, 275);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Extraction Status";
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Enabled = false;
            this.btnSaveTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTemplate.Location = new System.Drawing.Point(12, 305);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(91, 23);
            this.btnSaveTemplate.TabIndex = 25;
            this.btnSaveTemplate.Text = "Save Template";
            this.btnSaveTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.BtnSaveTemplateClick);
            // 
            // EnrollFromMicrophone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 340);
            this.Controls.Add(this.pbSoundLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbMicrophones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnrollFromMicrophone";
            this.Text = "Enroll From Microphone";
            this.Load += new System.EventHandler(this.EnrollFromMicrophoneLoad);
            this.gbMicrophones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPhraseId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPauseDuration)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPhraseDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbMicrophones;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbMicrophones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPhraseId;
        private System.Windows.Forms.NumericUpDown nudPauseDuration;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMaxPhraseDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbAutoDetect;
        private System.Windows.Forms.ProgressBar pbSoundLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}