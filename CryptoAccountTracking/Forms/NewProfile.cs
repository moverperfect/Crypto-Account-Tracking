using System;
using System.IO;
using System.Windows.Forms;

namespace CryptoAccountTracking.Forms
{
    public partial class NewProfile : Form
    {
        internal string ProfileName { get; set; } = "";

        public NewProfile()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (File.Exists(@".\" + txt_ProfileName.Text + ".json"))
            {
                MessageBox.Show("This Profile Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
            ProfileName = txt_ProfileName.Text;
        }
    }
}
