using System;
using System.Windows.Forms;
using CryptoAccountTracking.Objects;

namespace CryptoAccountTracking.Forms
{
    public partial class MainWindow : Form
    {
        private Profile profile;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_NewProfile_Click(object sender, EventArgs e)
        {
            // TODO Save the previous profile before creating a new one
            var newProfile = new NewProfile();
            var result = newProfile.ShowDialog();
            if (result != DialogResult.OK) return;

            profile = new Profile {Name = newProfile.ProfileName};
        }
    }
}
