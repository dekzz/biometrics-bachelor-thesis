using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Neurotec.Licensing;

namespace MultimodalBiometricsSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string Address = "/local";
            const string Port = "5000";
            const string Components = "Biometrics.FingerExtraction,Biometrics.FingerMatching,Devices.FingerScanners,Images.WSQ,Biometrics.FaceExtraction,Biometrics.FaceMatching,Biometrics.FaceDetection,Devices.Cameras,Media,Devices.Microphones,Biometrics.VoiceExtraction,Biometrics.VoiceMatching";

            try
            {
                NLicense.ObtainComponents(Address, Port, Components);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                NLicense.ReleaseComponents(Components);
            }
        }
    }
}
