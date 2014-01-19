namespace MultimodalBiometricsSystem.Fingerprint
{
    partial class IdentifyFingerprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyFingerprint));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openImageButton = new System.Windows.Forms.Button();
            this.openTemplatesButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.matchingGroupBox = new System.Windows.Forms.GroupBox();
            this.setMatchingFARButton = new System.Windows.Forms.Button();
            this.defaultMatchingFARButton = new System.Windows.Forms.Button();
            this.matchingFarComboBox = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtractionGroupBox = new System.Windows.Forms.GroupBox();
            this.setButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.UseQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.identifyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.fileForIdentificationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.templatesCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.matchingGroupBox.SuspendLayout();
            this.ExtractionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openImageButton
            // 
            this.openImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openImageButton.Location = new System.Drawing.Point(9, 183);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(92, 23);
            this.openImageButton.TabIndex = 8;
            this.openImageButton.Text = "Open Image";
            this.toolTip.SetToolTip(this.openImageButton, "Open fingerprint image for indentification");
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.OpenImageButtonClick);
            // 
            // openTemplatesButton
            // 
            this.openTemplatesButton.Image = ((System.Drawing.Image)(resources.GetObject("openTemplatesButton.Image")));
            this.openTemplatesButton.Location = new System.Drawing.Point(6, 24);
            this.openTemplatesButton.Name = "openTemplatesButton";
            this.openTemplatesButton.Size = new System.Drawing.Size(30, 23);
            this.openTemplatesButton.TabIndex = 5;
            this.toolTip.SetToolTip(this.openTemplatesButton, "Open templates files (*.data) ");
            this.openTemplatesButton.UseVisualStyleBackColor = true;
            this.openTemplatesButton.Click += new System.EventHandler(this.OpenTemplatesButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.matchingGroupBox);
            this.groupBox3.Controls.Add(this.listView);
            this.groupBox3.Controls.Add(this.ExtractionGroupBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.identifyButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 236);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identification";
            // 
            // matchingGroupBox
            // 
            this.matchingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matchingGroupBox.Controls.Add(this.setMatchingFARButton);
            this.matchingGroupBox.Controls.Add(this.defaultMatchingFARButton);
            this.matchingGroupBox.Controls.Add(this.matchingFarComboBox);
            this.matchingGroupBox.Location = new System.Drawing.Point(476, 14);
            this.matchingGroupBox.Name = "matchingGroupBox";
            this.matchingGroupBox.Size = new System.Drawing.Size(154, 76);
            this.matchingGroupBox.TabIndex = 21;
            this.matchingGroupBox.TabStop = false;
            this.matchingGroupBox.Text = "Matching FAR";
            // 
            // setMatchingFARButton
            // 
            this.setMatchingFARButton.Enabled = false;
            this.setMatchingFARButton.Location = new System.Drawing.Point(6, 45);
            this.setMatchingFARButton.Name = "setMatchingFARButton";
            this.setMatchingFARButton.Size = new System.Drawing.Size(63, 23);
            this.setMatchingFARButton.TabIndex = 21;
            this.setMatchingFARButton.Text = "Set";
            this.setMatchingFARButton.UseVisualStyleBackColor = true;
            this.setMatchingFARButton.Click += new System.EventHandler(this.SetMatchingFarButtonClick);
            // 
            // defaultMatchingFARButton
            // 
            this.defaultMatchingFARButton.Location = new System.Drawing.Point(75, 45);
            this.defaultMatchingFARButton.Name = "defaultMatchingFARButton";
            this.defaultMatchingFARButton.Size = new System.Drawing.Size(63, 23);
            this.defaultMatchingFARButton.TabIndex = 20;
            this.defaultMatchingFARButton.Text = "Default";
            this.defaultMatchingFARButton.UseVisualStyleBackColor = true;
            this.defaultMatchingFARButton.Click += new System.EventHandler(this.DefaultMatchingFarButtonClick);
            // 
            // matchingFarComboBox
            // 
            this.matchingFarComboBox.FormattingEnabled = true;
            this.matchingFarComboBox.Location = new System.Drawing.Point(9, 19);
            this.matchingFarComboBox.Name = "matchingFarComboBox";
            this.matchingFarComboBox.Size = new System.Drawing.Size(73, 21);
            this.matchingFarComboBox.TabIndex = 19;
            this.matchingFarComboBox.Enter += new System.EventHandler(this.MatchingFarComboBoxEnter);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Location = new System.Drawing.Point(9, 97);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(621, 133);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 335;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 136;
            // 
            // ExtractionGroupBox
            // 
            this.ExtractionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtractionGroupBox.Controls.Add(this.setButton);
            this.ExtractionGroupBox.Controls.Add(this.defaultButton);
            this.ExtractionGroupBox.Controls.Add(this.thresholdNumericUpDown);
            this.ExtractionGroupBox.Controls.Add(this.ThresholdLabel);
            this.ExtractionGroupBox.Controls.Add(this.UseQualityCheckBox);
            this.ExtractionGroupBox.Location = new System.Drawing.Point(321, 14);
            this.ExtractionGroupBox.Name = "ExtractionGroupBox";
            this.ExtractionGroupBox.Size = new System.Drawing.Size(149, 76);
            this.ExtractionGroupBox.TabIndex = 12;
            this.ExtractionGroupBox.TabStop = false;
            // 
            // setButton
            // 
            this.setButton.Enabled = false;
            this.setButton.Location = new System.Drawing.Point(6, 45);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(63, 23);
            this.setButton.TabIndex = 11;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.SetButtonClick);
            // 
            // defaultButton
            // 
            this.defaultButton.Enabled = false;
            this.defaultButton.Location = new System.Drawing.Point(75, 45);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(63, 23);
            this.defaultButton.TabIndex = 10;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.DefaultButtonClick);
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(69, 19);
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.thresholdNumericUpDown.TabIndex = 9;
            this.thresholdNumericUpDown.Value = new decimal(new int[] {
            39,
            0,
            0,
            0});
            this.thresholdNumericUpDown.Click += new System.EventHandler(this.ThresholdNumericUpDownEnter);
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(6, 23);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.ThresholdLabel.TabIndex = 8;
            this.ThresholdLabel.Text = "Threshold:";
            // 
            // UseQualityCheckBox
            // 
            this.UseQualityCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseQualityCheckBox.AutoSize = true;
            this.UseQualityCheckBox.Checked = true;
            this.UseQualityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseQualityCheckBox.Location = new System.Drawing.Point(9, 0);
            this.UseQualityCheckBox.Name = "UseQualityCheckBox";
            this.UseQualityCheckBox.Size = new System.Drawing.Size(80, 17);
            this.UseQualityCheckBox.TabIndex = 7;
            this.UseQualityCheckBox.Text = "Use Quality";
            this.UseQualityCheckBox.UseVisualStyleBackColor = true;
            this.UseQualityCheckBox.CheckedChanged += new System.EventHandler(this.UseQualityCheckBoxCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // identifyButton
            // 
            this.identifyButton.Enabled = false;
            this.identifyButton.Location = new System.Drawing.Point(9, 19);
            this.identifyButton.Name = "identifyButton";
            this.identifyButton.Size = new System.Drawing.Size(92, 23);
            this.identifyButton.TabIndex = 0;
            this.identifyButton.Text = "&Identify";
            this.identifyButton.UseVisualStyleBackColor = true;
            this.identifyButton.Click += new System.EventHandler(this.IdentifyButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel);
            this.groupBox2.Controls.Add(this.fileForIdentificationLabel);
            this.groupBox2.Controls.Add(this.openImageButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 212);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image for identification";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(9, 19);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(621, 158);
            this.panel.TabIndex = 11;
            // 
            // fileForIdentificationLabel
            // 
            this.fileForIdentificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileForIdentificationLabel.Location = new System.Drawing.Point(107, 188);
            this.fileForIdentificationLabel.Name = "fileForIdentificationLabel";
            this.fileForIdentificationLabel.Size = new System.Drawing.Size(523, 13);
            this.fileForIdentificationLabel.TabIndex = 10;
            this.fileForIdentificationLabel.Text = "file for identification";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.templatesCountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.openTemplatesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Templates loading";
            // 
            // templatesCountLabel
            // 
            this.templatesCountLabel.AutoSize = true;
            this.templatesCountLabel.Location = new System.Drawing.Point(142, 34);
            this.templatesCountLabel.Name = "templatesCountLabel";
            this.templatesCountLabel.Size = new System.Drawing.Size(82, 13);
            this.templatesCountLabel.TabIndex = 7;
            this.templatesCountLabel.Text = "templates count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Templates loaded:";
            // 
            // IdentifyFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdentifyFingerprint";
            this.Text = "Identify Fingerprint";
            this.Load += new System.EventHandler(this.IdentifyFingerLoad);
            this.VisibleChanged += new System.EventHandler(this.IdentifyFingerVisibleChanged);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.matchingGroupBox.ResumeLayout(false);
            this.ExtractionGroupBox.ResumeLayout(false);
            this.ExtractionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox matchingGroupBox;
        private System.Windows.Forms.Button setMatchingFARButton;
        private System.Windows.Forms.Button defaultMatchingFARButton;
        private System.Windows.Forms.ComboBox matchingFarComboBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox ExtractionGroupBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.CheckBox UseQualityCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button identifyButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label fileForIdentificationLabel;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label templatesCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openTemplatesButton;
    }
}