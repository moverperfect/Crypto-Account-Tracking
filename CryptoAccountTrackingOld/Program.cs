using System;
using System.Windows.Forms;

namespace CryptoAccountTracking
{
    static class Program
    {
        internal static Profile MainProfile;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainProfile = FileHandler.LoadProfile(@"Profile1.txt");
            if (MainProfile == null)
            {
                MainProfile = new Profile { ProfileName = "Profile1" };
                FileHandler.SaveProfile(MainProfile, @"Profile1.txt");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            FileHandler.SaveProfile(MainProfile, @"Profile1.txt");
        }
    }
}
