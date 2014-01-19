using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Licensing;

namespace MultimodalBiometricsSystem
{
    public partial class frmBiometrics : Form
    {
        string job;
        public frmBiometrics(string job)
        {
            InitializeComponent();
            this.job = job;
        }

        private void frmBiometrics_Load(object sender, EventArgs e)
        {
            btnGo.Text = job;
            statusLabel.Text = "Choose biometric characteristic!";
        }

        private NFExtractor _extractorFingerprint;
        private NLExtractor _extractorFace;
        private NSExtractor _extractorVoice;
        private NMatcher _matcher;

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (radFingerprint.Checked)
            {
                _extractorFingerprint = new NFExtractor();
                _matcher = new NMatcher();

                if (job == "Enrollment")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Fingerprint.EnrollFromImage frmEnrollFromImage = new Fingerprint.EnrollFromImage();

                    frmEnrollFromImage.Extractor = _extractorFingerprint;
                    frmEnrollFromImage.Show();
                }
                if (job == "Verification")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Fingerprint.VerifyFingerprint frmVerifyFingerprint = new Fingerprint.VerifyFingerprint();

                    frmVerifyFingerprint.Extractor = _extractorFingerprint;
                    frmVerifyFingerprint.Matcher = _matcher;
                    frmVerifyFingerprint.Show();
                }
                if (job == "Identification")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Fingerprint.IdentifyFingerprint frmIdentifyFingerprint = new Fingerprint.IdentifyFingerprint();

                    frmIdentifyFingerprint.Extractor = _extractorFingerprint;
                    frmIdentifyFingerprint.Matcher = _matcher;
                    frmIdentifyFingerprint.Show();
                }
            }
            if (radFace.Checked)
            {
                _extractorFace = new NLExtractor();
                _matcher = new NMatcher();

                if (job == "Enrollment")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Face.EnrollFromImage frmEnrollFromImage = new Face.EnrollFromImage();

                    frmEnrollFromImage.Extractor = _extractorFace;
                    frmEnrollFromImage.Show();

                    /*
                    Face.EnrollFromCamera frmEnrollFromCamera = new Face.EnrollFromCamera();

                    frmEnrollFromCamera.Extractor = _extractorFace;
                    frmEnrollFromCamera.Show();
                    */
                }
                if (job == "Verification")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Face.VerifyFace frmVerifyFace = new Face.VerifyFace();

                    frmVerifyFace.Extractor = _extractorFace;
                    frmVerifyFace.Matcher = _matcher;
                    frmVerifyFace.Show();
                }
                if (job == "Identification")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Face.IdentifyFace frmIdentifyFace = new Face.IdentifyFace();

                    frmIdentifyFace.Extractor = _extractorFace;
                    frmIdentifyFace.Matcher = _matcher;
                    frmIdentifyFace.Show();
                }
            }
            if (radVoice.Checked)
            {
                _extractorVoice = new NSExtractor();
                _matcher = new NMatcher();

                if (job == "Enrollment")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Voice.EnrollFromFile frmEnrollFromFile = new Voice.EnrollFromFile();

                    frmEnrollFromFile.Extractor = _extractorVoice;
                    frmEnrollFromFile.Show();

                    /*
                    Voice.EnrollFromMicrophone frmEnrollFromMicrophone = new Voice.EnrollFromMicrophone();

                    frmEnrollFromMicrophone.Extractor = _extractorVoice;
                    frmEnrollFromMicrophone.Show();
                    */
                }
                if (job == "Verification")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Voice.VerifyVoice frmVerifyVoice = new Voice.VerifyVoice();

                    frmVerifyVoice.Extractor = _extractorVoice;
                    frmVerifyVoice.Matcher = _matcher;
                    frmVerifyVoice.Show();
                }
                if (job == "Identification")
                {
                    statusLabel.Text = "Starting " + job + " process!";
                    Voice.IdentifyVoice frmIdentifyVoice = new Voice.IdentifyVoice();

                    frmIdentifyVoice.Extractor = _extractorVoice;
                    frmIdentifyVoice.Matcher = _matcher;
                    frmIdentifyVoice.Show();
                }
            }
        }
    }
}
