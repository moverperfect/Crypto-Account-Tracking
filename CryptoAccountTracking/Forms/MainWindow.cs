using System;
using System.Windows.Forms;
using CryptoAccountTracking.Handlers;
using CryptoAccountTracking.Objects;

namespace CryptoAccountTracking.Forms
{
    /// <summary>
    /// Main form to handle all functionality
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Current profile that the user has loaded
        /// </summary>
        private Profile _profile;

        /// <summary>
        /// Main form to handle all functionality
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// After the profile has been loaded, set up the form to align with loaded profile
        /// </summary>
        private void InitiateLoadedProfile()
        {
            lbl_Profile.Text = "Profile: " + _profile.Name;
            RefreshAccountsTable();
        }

        /// <summary>
        /// Refresh the accounts table
        /// </summary>
        private void RefreshAccountsTable()
        {
            // TODO Populate the accounts table
        }

        /// <summary>
        /// Ask the user for a name for the new profile
        /// </summary>
        private void btn_NewProfile_Click(object sender, EventArgs e)
        {
            // TODO Save the previous profile before creating a new one and change this to a save dialog box
            var newProfile = new NewProfile();
            var result = newProfile.ShowDialog();
            if (result != DialogResult.OK) return;

            _profile = new Profile {Name = newProfile.ProfileName};
            InitiateLoadedProfile();
        }

        /// <summary>
        /// Asks for the location of the profile to be loaded
        /// </summary>
        private void btn_LoadProfile_Click(object sender, EventArgs e)
        {
            if (ofd_Profile.ShowDialog() == DialogResult.OK)
            {
                _profile = FileHandler.LoadProfile(ofd_Profile.FileName);
                InitiateLoadedProfile();
            }
        }

        /// <summary>
        /// On close, save the loaded profile
        /// </summary>
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_profile == null) return;
            FileHandler.SaveProfile(_profile, _profile.Name + ".json");
        }
    }
}
