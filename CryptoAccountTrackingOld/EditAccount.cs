using System;
using System.Windows.Forms;

namespace CryptoAccountTracking
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        public EditAccount(string name, string notes)
        {
            InitializeComponent();
            txt_Name.Text = name;
            txt_Notes.Text = notes;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
