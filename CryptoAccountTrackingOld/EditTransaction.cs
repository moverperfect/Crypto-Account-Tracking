using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoAccountTracking
{
    internal partial class EditTransaction : Form
    {
        internal NetTransfer Transaction { get; } = new NetTransfer();

        internal EditTransaction(List<AccountAddress> addressList, int selected)
        {
            InitializeComponent();

            var cbList = addressList.Select(accountAddress => accountAddress.Account.Name + " : " + accountAddress.Address.AddressName).ToList();

            cb_From.Items.AddRange(cbList.ToArray());
            cb_To.Items.AddRange(cbList.ToArray());
            cb_From.SelectedIndex = selected;
            cb_To.SelectedIndex = selected;
        }

        public EditTransaction(NetTransfer transaction, List<AccountAddress> addressList)
        {
            InitializeComponent();

            cb_From.Items.AddRange(new object[] {addressList});
            cb_To.Items.AddRange(new object[] {addressList});

            Transaction = transaction;
            dtp_Date.Value = transaction.Date;
            cb_From.Text = transaction.From;
            cb_To.Text = transaction.To;
            txt_Amount.Text = transaction.Amount.ToString();
            txt_Fee.Text = transaction.Fee.ToString();
            txt_Hash.Text = transaction.TransactionHash;
        }

        private void TextBoxNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Transaction.Date = dtp_Date.Value;
            Transaction.From = cb_From.Text;
            Transaction.To = cb_To.Text;
            Transaction.Amount = Convert.ToDecimal(txt_Amount.Text);
            Transaction.Fee = Convert.ToDecimal(txt_Fee.Text);
            Transaction.TransactionHash = txt_Hash.Text;

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
