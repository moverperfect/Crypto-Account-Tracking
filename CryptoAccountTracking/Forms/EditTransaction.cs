using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoAccountTracking.Objects;

namespace CryptoAccountTracking.Forms
{
    public partial class EditTransaction : Form
    {
        internal Transaction Transaction;

        private List<Account> _accounts;

        private Account _currentAccount;

        public EditTransaction(List<Account> accounts, Account currentAccount)
        {
            InitializeComponent();

            _accounts = accounts;
            _currentAccount = currentAccount;

            foreach (var account in _accounts)
            {
                cb_To.Items.Add(account.Address);
                cb_From.Items.Add(account.Address);
            }

            cb_To.Items.Add("External");
            cb_From.Items.Add("External");

            if (currentAccount == null) return;
            cb_To.SelectedIndex = _accounts.FindIndex(t => t.Address == currentAccount.Address);
            cb_From.SelectedIndex = cb_To.SelectedIndex;
            txt_Currency.Text = currentAccount.DefaultCurrency;
            txt_FeeCurrency.Text = currentAccount.DefaultCurrency;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction = new Transaction
                {
                    Date = dtp_Date.Value,
                    From = cb_From.Text,
                    To = cb_To.Text,
                    FromAmount = Convert.ToDecimal(txt_Amount.Text),
                    ToAmount = Convert.ToDecimal(txt_Amount.Text),
                    FromCurrency = txt_Currency.Text,
                    ToCurrency = txt_Currency.Text,
                    FeeAmount = Convert.ToDecimal(txt_Fee.Text),
                    FeeCurrency =  txt_FeeCurrency.Text,
                    Hash = txt_Hash.Text
                };

                DialogResult = DialogResult.OK;

                Close();
            }
            finally
            {
            }
        }
    }
}
