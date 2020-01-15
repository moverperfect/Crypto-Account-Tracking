using System;
using System.Windows.Forms;
using CryptoAccountTracking.Objects;

namespace CryptoAccountTracking.Forms
{
    internal partial class EditAccount : Form
    {
        internal Account account;

        internal EditAccount()
        {
            InitializeComponent();
        }

        private void cb_CustomAddress_CheckedChanged(object sender, EventArgs e)
        {
            txt_Address.Enabled = cb_CustomAddress.Checked;
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (!txt_Address.Enabled)
            {
                txt_Address.Text = txt_Name.Text;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            account = new Account
            {
                Name = txt_Name.Text,
                Address = txt_Address.Text,
                DefaultCurrency = txt_CurrencyCode.Text,
                Notes = txt_Notes.Text
            };

            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
