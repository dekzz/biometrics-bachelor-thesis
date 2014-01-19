using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultimodalBiometricsSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            string job = "Enrollment";
            frmBiometrics formBiometrics = new frmBiometrics(job);
            formBiometrics.Show();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            string job = "Verification";
            frmBiometrics formBiometrics = new frmBiometrics(job);
            formBiometrics.Show();
        }

        private void btnIdentification_Click(object sender, EventArgs e)
        {
            string job = "Identification";
            frmBiometrics formBiometrics = new frmBiometrics(job);
            formBiometrics.Show();
        }
    }
}
