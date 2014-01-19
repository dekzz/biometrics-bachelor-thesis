namespace MultimodalBiometricsSystem.Face
{
    partial class IdentifyFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyFace));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.templatesCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openTemplatesButton = new System.Windows.Forms.Button();
            this.facesView = new Neurotec.Biometrics.Gui.NLView();
            this.matchingFarComboBox = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.identifyButton = new System.Windows.Forms.Button();
            this.setMatchingFARButton = new System.Windows.Forms.Button();
            this.defaultMatchingFARButton = new System.Windows.Forms.Button();
            this.fileForIdentificationLabel = new System.Windows.Forms.Label();
            this.openImageButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.matchingGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.matchingGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(486, 57);
            this.groupBox1.TabIndex = 15;
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
            // openTemplatesButton
            // 
            this.openTemplatesButton.Image = ((System.Drawing.Image)(resources.GetObject("openTemplatesButton.Image")));
            this.openTemplatesButton.Location = new System.Drawing.Point(6, 24);
            this.openTemplatesButton.Name = "openTemplatesButton";
            this.openTemplatesButton.Size = new System.Drawing.Size(30, 23);
            this.openTemplatesButton.TabIndex = 5;
            this.openTemplatesButton.UseVisualStyleBackColor = true;
            this.openTemplatesButton.Click += new System.EventHandler(this.OpenTemplatesButtonClick);
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
            this.facesView.Location = new System.Drawing.Point(6, 45);
            this.facesView.Name = "facesView";
            this.facesView.Size = new System.Drawing.Size(474, 145);
            this.facesView.TabIndex = 15;
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
            this.listView.Location = new System.Drawing.Point(6, 53);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(474, 133);
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
            // identifyButton
            // 
            this.identifyButton.Enabled = false;
            this.identifyButton.Location = new System.Drawing.Point(9, 25);
            this.identifyButton.Name = "identifyButton";
            this.identifyButton.Size = new System.Drawing.Size(92, 23);
            this.identifyButton.TabIndex = 0;
            this.identifyButton.Text = "&Identify";
            this.identifyButton.UseVisualStyleBackColor = true;
            this.identifyButton.Click += new System.EventHandler(this.IdentifyButtonClick);
            // 
            // setMatchingFARButton
            // 
            this.setMatchingFARButton.Enabled = false;
            this.setMatchingFARButton.Location = new System.Drawing.Point(88, 17);
            this.setMatchingFARButton.Name = "setMatchingFARButton";
            this.setMatchingFARButton.Size = new System.Drawing.Size(63, 23);
            this.setMatchingFARButton.TabIndex = 21;
            this.setMatchingFARButton.Text = "Set";
            this.setMatchingFARButton.UseVisualStyleBackColor = true;
            this.setMatchingFARButton.Click += new System.EventHandler(this.SetMatchingFARButtonClick);
            // 
            // defaultMatchingFARButton
            // 
            this.defaultMatchingFARButton.Location = new System.Drawing.Point(157, 17);
            this.defaultMatchingFARButton.Name = "defaultMatchingFARButton";
            this.defaultMatchingFARButton.Size = new System.Drawing.Size(63, 23);
            this.defaultMatchingFARButton.TabIndex = 20;
            this.defaultMatchingFARButton.Text = "Default";
            this.defaultMatchingFARButton.UseVisualStyleBackColor = true;
            this.defaultMatchingFARButton.Click += new System.EventHandler(this.DefaultMatchingFARButtonClick);
            // 
            // fileForIdentificationLabel
            // 
            this.fileForIdentificationLabel.AutoSize = true;
            this.fileForIdentificationLabel.Location = new System.Drawing.Point(107, 21);
            this.fileForIdentificationLabel.Name = "fileForIdentificationLabel";
            this.fileForIdentificationLabel.Size = new System.Drawing.Size(97, 13);
            this.fileForIdentificationLabel.TabIndex = 10;
            this.fileForIdentificationLabel.Text = "file for identification";
            // 
            // openImageButton
            // 
            this.openImageButton.Image = ((System.Drawing.Image)(resources.GetObject("openImageButton.Image")));
            this.openImageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openImageButton.Location = new System.Drawing.Point(9, 16);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(92, 23);
            this.openImageButton.TabIndex = 8;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.OpenImageButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.openImageButton);
            this.groupBox2.Controls.Add(this.fileForIdentificationLabel);
            this.groupBox2.Controls.Add(this.facesView);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 196);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image for identification";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.matchingGroupBox);
            this.groupBox3.Controls.Add(this.listView);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.identifyButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 192);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identification";
            // 
            // matchingGroupBox
            // 
            this.matchingGroupBox.Controls.Add(this.setMatchingFARButton);
            this.matchingGroupBox.Controls.Add(this.defaultMatchingFARButton);
            this.matchingGroupBox.Controls.Add(this.matchingFarComboBox);
            this.matchingGroupBox.Location = new System.Drawing.Point(112, 8);
            this.matchingGroupBox.Name = "matchingGroupBox";
            this.matchingGroupBox.Size = new System.Drawing.Size(226, 43);
            this.matchingGroupBox.TabIndex = 21;
            this.matchingGroupBox.TabStop = false;
            this.matchingGroupBox.Text = "Matching FAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // IdentifyFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdentifyFace";
            this.Text = "Identify Face";
            this.Load += new System.EventHandler(this.IdentifyFaceLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.matchingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label templatesCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openTemplatesButton;
        private Neurotec.Biometrics.Gui.NLView facesView;
        private System.Windows.Forms.ComboBox matchingFarComboBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button identifyButton;
        private System.Windows.Forms.Button setMatchingFARButton;
        private System.Windows.Forms.Button defaultMatchingFARButton;
        private System.Windows.Forms.Label fileForIdentificationLabel;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox matchingGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
    }
}