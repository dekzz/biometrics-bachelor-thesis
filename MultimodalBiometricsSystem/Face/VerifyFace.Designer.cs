﻿namespace MultimodalBiometricsSystem.Face
{
    partial class VerifyFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyFace));
            this.matchingGroupBox = new System.Windows.Forms.GroupBox();
            this.setButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.matchingFarLabel = new System.Windows.Forms.Label();
            this.matchingFarComboBox = new System.Windows.Forms.ComboBox();
            this.openImageButton1 = new System.Windows.Forms.Button();
            this.openImageButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nlView2 = new Neurotec.Biometrics.Gui.NLView();
            this.nlView1 = new Neurotec.Biometrics.Gui.NLView();
            this.clearImagesButton = new System.Windows.Forms.Button();
            this.templateRightLabel = new System.Windows.Forms.Label();
            this.templateLeftLabel = new System.Windows.Forms.Label();
            this.templateNameLabel2 = new System.Windows.Forms.Label();
            this.templateNameLabel1 = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.matchingGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchingGroupBox
            // 
            this.matchingGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.matchingGroupBox.Controls.Add(this.setButton);
            this.matchingGroupBox.Controls.Add(this.defaultButton);
            this.matchingGroupBox.Controls.Add(this.matchingFarLabel);
            this.matchingGroupBox.Controls.Add(this.matchingFarComboBox);
            this.matchingGroupBox.Location = new System.Drawing.Point(213, 10);
            this.matchingGroupBox.MaximumSize = new System.Drawing.Size(600, 200);
            this.matchingGroupBox.Name = "matchingGroupBox";
            this.matchingGroupBox.Size = new System.Drawing.Size(206, 54);
            this.matchingGroupBox.TabIndex = 33;
            this.matchingGroupBox.TabStop = false;
            // 
            // setButton
            // 
            this.setButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setButton.Enabled = false;
            this.setButton.Location = new System.Drawing.Point(83, 26);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(51, 23);
            this.setButton.TabIndex = 21;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.SetButtonClick);
            // 
            // defaultButton
            // 
            this.defaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultButton.Location = new System.Drawing.Point(137, 26);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(63, 23);
            this.defaultButton.TabIndex = 20;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.DefaultButtonClick);
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
            // matchingFarComboBox
            // 
            this.matchingFarComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.matchingFarComboBox.FormattingEnabled = true;
            this.matchingFarComboBox.Location = new System.Drawing.Point(9, 28);
            this.matchingFarComboBox.Name = "matchingFarComboBox";
            this.matchingFarComboBox.Size = new System.Drawing.Size(68, 21);
            this.matchingFarComboBox.TabIndex = 19;
            this.matchingFarComboBox.Enter += new System.EventHandler(this.MatchingFarComboBoxEnter);
            // 
            // openImageButton1
            // 
            this.openImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("openImageButton1.Image")));
            this.openImageButton1.Location = new System.Drawing.Point(177, 39);
            this.openImageButton1.Name = "openImageButton1";
            this.openImageButton1.Size = new System.Drawing.Size(30, 23);
            this.openImageButton1.TabIndex = 34;
            this.toolTip.SetToolTip(this.openImageButton1, "Open first fingerprint image or template (*.dat) file");
            this.openImageButton1.UseVisualStyleBackColor = true;
            this.openImageButton1.Click += new System.EventHandler(this.OpenImageButton1Click);
            // 
            // openImageButton2
            // 
            this.openImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("openImageButton2.Image")));
            this.openImageButton2.Location = new System.Drawing.Point(425, 39);
            this.openImageButton2.Name = "openImageButton2";
            this.openImageButton2.Size = new System.Drawing.Size(30, 23);
            this.openImageButton2.TabIndex = 35;
            this.toolTip.SetToolTip(this.openImageButton2, "Open second fingerprint image or template (*.dat) file");
            this.openImageButton2.UseVisualStyleBackColor = true;
            this.openImageButton2.Click += new System.EventHandler(this.OpenImageButton2Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nlView2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nlView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 242);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // nlView2
            // 
            this.nlView2.AutoScroll = true;
            this.nlView2.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.nlView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nlView2.DetectionDetails = null;
            this.nlView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nlView2.FaceIds = null;
            this.nlView2.Image = null;
            this.nlView2.Location = new System.Drawing.Point(315, 3);
            this.nlView2.Name = "nlView2";
            this.nlView2.Size = new System.Drawing.Size(307, 236);
            this.nlView2.TabIndex = 4;
            // 
            // nlView1
            // 
            this.nlView1.AutoScroll = true;
            this.nlView1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.nlView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nlView1.DetectionDetails = null;
            this.nlView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nlView1.FaceIds = null;
            this.nlView1.Image = null;
            this.nlView1.Location = new System.Drawing.Point(3, 3);
            this.nlView1.Name = "nlView1";
            this.nlView1.Size = new System.Drawing.Size(306, 236);
            this.nlView1.TabIndex = 3;
            // 
            // clearImagesButton
            // 
            this.clearImagesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearImagesButton.Location = new System.Drawing.Point(272, 312);
            this.clearImagesButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearImagesButton.Name = "clearImagesButton";
            this.clearImagesButton.Size = new System.Drawing.Size(108, 23);
            this.clearImagesButton.TabIndex = 44;
            this.clearImagesButton.Text = "Clear Images";
            this.clearImagesButton.UseVisualStyleBackColor = true;
            this.clearImagesButton.Click += new System.EventHandler(this.ClearImagesButtonClick);
            // 
            // templateRightLabel
            // 
            this.templateRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.templateRightLabel.AutoSize = true;
            this.templateRightLabel.Location = new System.Drawing.Point(126, 375);
            this.templateRightLabel.Name = "templateRightLabel";
            this.templateRightLabel.Size = new System.Drawing.Size(70, 13);
            this.templateRightLabel.TabIndex = 50;
            this.templateRightLabel.Text = "template right";
            // 
            // templateLeftLabel
            // 
            this.templateLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.templateLeftLabel.AutoSize = true;
            this.templateLeftLabel.Location = new System.Drawing.Point(126, 351);
            this.templateLeftLabel.Name = "templateLeftLabel";
            this.templateLeftLabel.Size = new System.Drawing.Size(64, 13);
            this.templateLeftLabel.TabIndex = 49;
            this.templateLeftLabel.Text = "template left";
            // 
            // templateNameLabel2
            // 
            this.templateNameLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.templateNameLabel2.AutoSize = true;
            this.templateNameLabel2.Location = new System.Drawing.Point(9, 375);
            this.templateNameLabel2.Name = "templateNameLabel2";
            this.templateNameLabel2.Size = new System.Drawing.Size(117, 13);
            this.templateNameLabel2.TabIndex = 48;
            this.templateNameLabel2.Text = "Image or template right:";
            // 
            // templateNameLabel1
            // 
            this.templateNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.templateNameLabel1.AutoSize = true;
            this.templateNameLabel1.Location = new System.Drawing.Point(9, 351);
            this.templateNameLabel1.Name = "templateNameLabel1";
            this.templateNameLabel1.Size = new System.Drawing.Size(111, 13);
            this.templateNameLabel1.TabIndex = 47;
            this.templateNameLabel1.Text = "Image or template left:";
            // 
            // verifyButton
            // 
            this.verifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.verifyButton.Enabled = false;
            this.verifyButton.Location = new System.Drawing.Point(516, 385);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(121, 23);
            this.verifyButton.TabIndex = 46;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.VerifyButtonClick);
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(9, 398);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(33, 13);
            this.msgLabel.TabIndex = 45;
            this.msgLabel.Text = "score";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // VerifyFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 420);
            this.Controls.Add(this.templateRightLabel);
            this.Controls.Add(this.templateLeftLabel);
            this.Controls.Add(this.templateNameLabel2);
            this.Controls.Add(this.templateNameLabel1);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.clearImagesButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.openImageButton1);
            this.Controls.Add(this.openImageButton2);
            this.Controls.Add(this.matchingGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerifyFace";
            this.Text = "Verify Face";
            this.Load += new System.EventHandler(this.VerifyFaceLoad);
            this.matchingGroupBox.ResumeLayout(false);
            this.matchingGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox matchingGroupBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Label matchingFarLabel;
        private System.Windows.Forms.ComboBox matchingFarComboBox;
        private System.Windows.Forms.Button openImageButton1;
        private System.Windows.Forms.Button openImageButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Neurotec.Biometrics.Gui.NLView nlView2;
        private Neurotec.Biometrics.Gui.NLView nlView1;
        private System.Windows.Forms.Button clearImagesButton;
        private System.Windows.Forms.Label templateRightLabel;
        private System.Windows.Forms.Label templateLeftLabel;
        private System.Windows.Forms.Label templateNameLabel2;
        private System.Windows.Forms.Label templateNameLabel1;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
    }
}