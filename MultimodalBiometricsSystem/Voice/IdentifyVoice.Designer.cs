namespace MultimodalBiometricsSystem.Voice
{
    partial class IdentifyVoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyVoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTemplatesCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenTemplates = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.matchingGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.cbMatchingFar = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.lblFileForIdentification = new System.Windows.Forms.Label();
            this.btnOpenAudio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.matchingGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblTemplatesCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenTemplates);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 57);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Templates loading";
            // 
            // lblTemplatesCount
            // 
            this.lblTemplatesCount.AutoSize = true;
            this.lblTemplatesCount.Location = new System.Drawing.Point(142, 30);
            this.lblTemplatesCount.Name = "lblTemplatesCount";
            this.lblTemplatesCount.Size = new System.Drawing.Size(82, 13);
            this.lblTemplatesCount.TabIndex = 7;
            this.lblTemplatesCount.Text = "templates count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Templates loaded:";
            // 
            // btnOpenTemplates
            // 
            this.btnOpenTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenTemplates.Image")));
            this.btnOpenTemplates.Location = new System.Drawing.Point(12, 24);
            this.btnOpenTemplates.Name = "btnOpenTemplates";
            this.btnOpenTemplates.Size = new System.Drawing.Size(30, 23);
            this.btnOpenTemplates.TabIndex = 5;
            this.btnOpenTemplates.UseVisualStyleBackColor = true;
            this.btnOpenTemplates.Click += new System.EventHandler(this.BtnOpenTemplatesClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.matchingGroupBox);
            this.groupBox3.Controls.Add(this.listView);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnIdentify);
            this.groupBox3.Location = new System.Drawing.Point(15, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 194);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identification";
            // 
            // matchingGroupBox
            // 
            this.matchingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matchingGroupBox.Controls.Add(this.btnSet);
            this.matchingGroupBox.Controls.Add(this.btnDefault);
            this.matchingGroupBox.Controls.Add(this.cbMatchingFar);
            this.matchingGroupBox.Location = new System.Drawing.Point(235, 14);
            this.matchingGroupBox.Name = "matchingGroupBox";
            this.matchingGroupBox.Size = new System.Drawing.Size(220, 44);
            this.matchingGroupBox.TabIndex = 21;
            this.matchingGroupBox.TabStop = false;
            this.matchingGroupBox.Text = "Matching FAR";
            // 
            // btnSet
            // 
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(85, 17);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(63, 23);
            this.btnSet.TabIndex = 21;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSetClick);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(154, 17);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(63, 23);
            this.btnDefault.TabIndex = 20;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefaultClick);
            // 
            // cbMatchingFar
            // 
            this.cbMatchingFar.FormattingEnabled = true;
            this.cbMatchingFar.Location = new System.Drawing.Point(6, 19);
            this.cbMatchingFar.Name = "cbMatchingFar";
            this.cbMatchingFar.Size = new System.Drawing.Size(73, 21);
            this.cbMatchingFar.TabIndex = 19;
            this.cbMatchingFar.Enter += new System.EventHandler(this.CbMatchingFarEnter);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Location = new System.Drawing.Point(9, 64);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(446, 124);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Enabled = false;
            this.btnIdentify.Location = new System.Drawing.Point(9, 19);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(110, 23);
            this.btnIdentify.TabIndex = 0;
            this.btnIdentify.Text = "&Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.BtnIdentifyClick);
            // 
            // lblFileForIdentification
            // 
            this.lblFileForIdentification.AutoSize = true;
            this.lblFileForIdentification.Location = new System.Drawing.Point(125, 29);
            this.lblFileForIdentification.Name = "lblFileForIdentification";
            this.lblFileForIdentification.Size = new System.Drawing.Size(97, 13);
            this.lblFileForIdentification.TabIndex = 10;
            this.lblFileForIdentification.Text = "file for identification";
            // 
            // btnOpenAudio
            // 
            this.btnOpenAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAudio.Image")));
            this.btnOpenAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAudio.Location = new System.Drawing.Point(9, 24);
            this.btnOpenAudio.Name = "btnOpenAudio";
            this.btnOpenAudio.Size = new System.Drawing.Size(110, 23);
            this.btnOpenAudio.TabIndex = 8;
            this.btnOpenAudio.Text = "Open Audio File";
            this.btnOpenAudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAudio.UseVisualStyleBackColor = true;
            this.btnOpenAudio.Click += new System.EventHandler(this.BtnOpenAudioFileClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblFileForIdentification);
            this.groupBox2.Controls.Add(this.btnOpenAudio);
            this.groupBox2.Location = new System.Drawing.Point(15, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 53);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voice template for identification";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // IdentifyVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdentifyVoice";
            this.Text = "Identify Voice";
            this.Load += new System.EventHandler(this.IdentifyVoiceLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.matchingGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTemplatesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenTemplates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox matchingGroupBox;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ComboBox cbMatchingFar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Label lblFileForIdentification;
        private System.Windows.Forms.Button btnOpenAudio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}