using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CryptoAccountTracking.Objects;

namespace CryptoAccountTracking.Forms
{
    public partial class EditTrade : Form
    {
        internal Transaction Transaction;

        private readonly List<Account> _accounts;

        private Account _currentAccount;

        public EditTrade(List<Account> accounts, Account currentAccount)
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
            cb_To.SelectedIndex = _accounts.FindIndex(t => t.Address == _currentAccount.Address);
            cb_From.SelectedIndex = cb_To.SelectedIndex;
            txt_FromCurrency.Text = currentAccount.DefaultCurrency;
            txt_ToCurrency.Text = currentAccount.DefaultCurrency;
            txt_FeeCurrency.Text = currentAccount.DefaultCurrency;
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            try
            {
                Transaction = new Transaction
                {
                    Date = dtp_Date.Value,
                    From = cb_From.Text,
                    To = cb_To.Text,
                    FromAmount = Convert.ToDecimal(txt_FromAmount.Text),
                    ToAmount = Convert.ToDecimal(txt_ToAmount.Text),
                    FromCurrency = txt_FromCurrency.Text,
                    ToCurrency = txt_ToCurrency.Text,
                    FeeAmount = Convert.ToDecimal(txt_Fee.Text),
                    FeeCurrency = txt_FeeCurrency.Text,
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
