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
        /// Current profile selected by the user
        /// </summary>
        private Account _selectedAccount;

        /// <summary>
        /// Main form to handle all functionality
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            ofd_Profile.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;


            dg_Accounts.Columns.Add("Name", "Name");
            dg_Accounts.Columns.Add("Address", "Address");
            dg_Accounts.Columns.Add("Value", "Value");
            dg_Accounts.Columns.Add("Notes", "Notes");

            dg_Balance.Columns.Add("Currency", "Currency");
            dg_Balance.Columns.Add("Balance", "Balance");

            dg_Transactions.Columns.Add("Date", "Date");
            dg_Transactions.Columns.Add("From", "From");
            dg_Transactions.Columns.Add("To", "To");
            dg_Transactions.Columns.Add("Amount", "Amount");
            dg_Transactions.Columns.Add("Currency", "Currency");
            dg_Transactions.Columns.Add("Fee", "Fee");
            dg_Transactions.Columns.Add("Fee Currency", "Fee Currency");
            dg_Transactions.Columns.Add("Hash", "Hash");

            dg_Trades.Columns.Add("Date", "Date");
            dg_Trades.Columns.Add("From", "From");
            dg_Trades.Columns.Add("To", "To");
            dg_Trades.Columns.Add("From Amount", "From Amount");
            dg_Trades.Columns.Add("From Currency", "From Currency");
            dg_Trades.Columns.Add("To Amount", "To Amount");
            dg_Trades.Columns.Add("To Currency", "To Currency");
            dg_Trades.Columns.Add("Rate", "Rate");
            dg_Trades.Columns.Add("Fee", "Fee");
            dg_Trades.Columns.Add("Fee Currency", "Fee Currency");
            dg_Trades.Columns.Add("Hash", "Hash");

            dg_TotalPortfolio.Columns.Add("Ticker", "Ticker");
            dg_TotalPortfolio.Columns.Add("Currency Name", "Currency Name");
            dg_TotalPortfolio.Columns.Add("Total", "Total");
            dg_TotalPortfolio.Columns.Add("Value", "Value");

            dg_CurrencyLocation.Columns.Add("Account Name", "Account Name");
            dg_CurrencyLocation.Columns.Add("Address", "Address");
            dg_CurrencyLocation.Columns.Add("Total", "Total");
            dg_CurrencyLocation.Columns.Add("Value", "Value");
        }

        /// <summary>
        /// After the profile has been loaded, set up the form to align with loaded profile
        /// </summary>
        private void InitiateLoadedProfile()
        {
            lbl_Profile.Text = "Profile: " + _profile.Name;

            btn_CreateAccount.Enabled = true;
            //btn_EditAccount.Enabled = true;
            //btn_DeleteAccount.Enabled = true;

            RefreshAccounts();
        }

        /// <summary>
        /// Refresh the accounts table
        /// </summary>
        private void RefreshAccounts()
        {
            string selectedAddress = null;
            if (dg_Accounts.SelectedRows.Count == 1)
            {
                selectedAddress = (string)dg_Accounts.SelectedRows[0].Cells["Address"].Value;
            }

            dg_Accounts.Rows.Clear();
            cb_Bitfinex.Items.Clear();
            cb_Gdax.Items.Clear();

            // Check if a profile is loaded
            if (_profile == null)
            {
                btn_CreateAccount.Enabled = false;
                btn_EditAccount.Enabled = false;
                btn_DeleteAccount.Enabled = false;
            }
            else
            {
                foreach (var account in _profile.Accounts)
                {
                    dg_Accounts.Rows.Add(account.Name, account.Address,
                        account.SingleCurrencyHoldingsAtDate(_profile.Transactions, DateTime.Now,
                            account.DefaultCurrency).ToString("0.#############################") + " " +
                        account.DefaultCurrency, account.Notes);

                    cb_Bitfinex.Items.Add(account.Address);
                    cb_Gdax.Items.Add(account.Address);
                }

                if (_profile.Accounts.Count > 0)
                {
                    if (selectedAddress != null)
                    {
                        for (var i = 0; i < dg_Accounts.Rows.Count; i++)
                        {
                            if (selectedAddress != (string) dg_Accounts.Rows[i].Cells["Address"].Value) continue;
                            dg_Accounts.Rows[i].Cells[0].Selected = true;
                            break;
                        }
                    }

                    if (dg_Accounts.SelectedRows.Count == 0)
                    {
                        dg_Accounts.Rows[0].Cells[0].Selected = true;
                    }

                    btn_CreateTransaction.Enabled = true;
                    //btn_EditTransaction.Enabled = true;
                    //btn_DeleteTransaction.Enabled = true;

                    btn_CreateTrade.Enabled = true;
                    //btn_EditTrade.Enabled = true;
                    //btn_DeleteTrade.Enabled = true;
                }
            }

            RefreshTotalPortfolio();
        }

        private void RefreshTotalPortfolio()
        {
            dg_TotalPortfolio.Rows.Clear();

            if (_profile != null)
            {
                var currencyTotals = _profile.ListAllCurrencyTotals();

                foreach (var currencyTotal in currencyTotals)
                {
                    dg_TotalPortfolio.Rows.Add(currencyTotal.Key,
                        _profile.Currencies.Find(t => t.Ticker == currencyTotal.Key).Name,
                        currencyTotal.Value.ToString("0.#############################"), "N/A");
                }

                if (_profile.Currencies.Count > 0)
                {
                    dg_TotalPortfolio.Rows[0].Cells[0].Selected = true;
                }
            }
        }

        private void RefreshCurrencyTable()
        {
            dg_Balance.Rows.Clear();

            var holdings = _selectedAccount.AllCurrencyHoldingsAtDate(_profile.Transactions, DateTime.Now);

            foreach (var holding in holdings)
            {
                dg_Balance.Rows.Add(holding.Code, holding.Holdings.ToString("0.#############################"));
            }
        }

        private void RefreshTransactionsTable()
        {
            dg_Transactions.Rows.Clear();

            var transactions = _profile.Transactions.FindAll(t =>
                t.FromAmount == t.ToAmount && t.FromCurrency == t.ToCurrency &&
                (t.From == _selectedAccount.Address || t.To == _selectedAccount.Address));

            foreach (var transaction in transactions)
            {
                if (cb_CurrencyFilter.Text != "" && cb_CurrencyFilter.Text != transaction.FromCurrency) continue;
                dg_Transactions.Rows.Add(transaction.Date, transaction.From, transaction.To,
                    transaction.FromAmount.ToString("0.#############################"),
                    transaction.FromCurrency, transaction.FeeAmount.ToString("0.#############################"),
                    transaction.FeeCurrency, transaction.Hash);
            }
        }

        private void RefreshTradesTable()
        {
            dg_Trades.Rows.Clear();

            var trades = _profile.Transactions.FindAll(t =>
                t.FromCurrency != t.ToCurrency &&
                (t.From == _selectedAccount.Address || t.To == _selectedAccount.Address));

            foreach (var trade in trades)
            {
                if (cb_CurrencyFilter.Text != "" && cb_CurrencyFilter.Text != trade.FromCurrency &&
                    cb_CurrencyFilter.Text != trade.ToCurrency && cb_CurrencyFilter.Text != trade.FeeCurrency) continue;
                var rate = (trade.ToAmount + trade.FeeAmount) / trade.FromAmount;
                if (rate < 1M)
                {
                    rate = Math.Round(1M / rate, 2);
                }

                dg_Trades.Rows.Add(trade.Date, trade.From, trade.To,
                    trade.FromAmount.ToString("0.#############################"), trade.FromCurrency,
                    trade.ToAmount.ToString("0.#############################"), trade.ToCurrency, rate,
                    trade.FeeAmount.ToString("0.#############################"), trade.FeeCurrency, trade.Hash);
            }
        }

        private void RefreshCurrencyLocationTable()
        {
            dg_CurrencyLocation.Rows.Clear();

            if (dg_TotalPortfolio.SelectedRows.Count == 0) return;

            var selectedCurrency = (string)dg_TotalPortfolio.SelectedRows[0].Cells["Ticker"].Value;

            foreach (var account in _profile.Accounts)
            {
                var balance =
                    account.SingleCurrencyHoldingsAtDate(_profile.Transactions, DateTime.Now, selectedCurrency);

                dg_CurrencyLocation.Rows.Add(account.Name, account.Address, balance.ToString("0.#############################"), "N/A");
            }
        }

        /// <summary>
        /// Ask the user for a name for the new profile
        /// </summary>
        private void btn_CreateProfile_Click(object sender, EventArgs e)
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

        private void dg_Accounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_Accounts.SelectedRows.Count == 1)
            {
                _selectedAccount =
                    _profile.Accounts.Find(t => t.Address == (string)dg_Accounts.SelectedRows[0].Cells["Address"].Value);
            }

            RefreshCurrencyTable();
            RefreshTransactionsTable();
            RefreshTradesTable();
        }

        private void dg_TotalPortfolio_SelectionChanged(object sender, EventArgs e)
        {
            RefreshCurrencyLocationTable();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            var editAccount = new EditAccount();

            var result = editAccount.ShowDialog();

            if (result != DialogResult.OK) return;

            while (_profile.Accounts.Find(t => t.Address == editAccount.account.Address) != null)
            {
                if (result != DialogResult.OK) return;
                MessageBox.Show("This address name already exists", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                result = editAccount.ShowDialog();
            }

            _profile.Accounts.Add(editAccount.account);

            RefreshAccounts();
        }

        private void btn_CreateTransaction_Click(object sender, EventArgs e)
        {
            var editTransaction = new EditTransaction(_profile.Accounts, _selectedAccount);

            var result = editTransaction.ShowDialog();
            if (result != DialogResult.OK) return;

            _profile.Transactions.Add(editTransaction.Transaction);

            if (_profile.Currencies.Find(t => t.Ticker == editTransaction.Transaction.FromCurrency) == null)
            {
                _profile.Currencies.Add(new Currency
                {
                    Name = "",
                    Ticker = editTransaction.Transaction.FromCurrency
                });
            }

            if (_profile.Currencies.Find(t => t.Ticker == editTransaction.Transaction.ToCurrency) == null)
            {
                _profile.Currencies.Add(new Currency
                {
                    Name = "",
                    Ticker = editTransaction.Transaction.ToCurrency
                });
            }

            if (_profile.Currencies.Find(t => t.Ticker == editTransaction.Transaction.FeeCurrency) == null)
            {
                _profile.Currencies.Add(new Currency
                {
                    Name = "",
                    Ticker = editTransaction.Transaction.FeeCurrency
                });
            }

            _profile.SortTransactions();

            RefreshAccounts();
        }

        private void btn_CreateTrade_Click(object sender, EventArgs e)
        {
            var editTrade = new EditTrade(_profile.Accounts, _selectedAccount);

            var result = editTrade.ShowDialog();
            if (result != DialogResult.OK) return;

            _profile.Transactions.Add(editTrade.Transaction);

            if (_profile.Currencies.Find(t => t.Ticker == editTrade.Transaction.FromCurrency) == null)
            {
                _profile.Currencies.Add(new Currency
                {
                    Name = "",
                    Ticker = editTrade.Transaction.FromCurrency
                });
            }

            if (_profile.Currencies.Find(t => t.Ticker == editTrade.Transaction.ToCurrency) == null)
            {
                _profile.Currencies.Add(new Currency
                {
                    Name = "",
                    Ticker = editTrade.Transaction.ToCurrency
                });
            }

            if (_profile.Currencies.Find(t => t.Ticker == editTrade.Transaction.FeeCurrency) == null)
            {
                _profile.Currencies.Add(new Currency
                {
                    Name = "",
                    Ticker = editTrade.Transaction.FeeCurrency
                });
            }

            _profile.SortTransactions();

            RefreshAccounts();
        }

        private void btn_BitfinexOpen_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txt_BitfinexPath.Text = openDialog.FileName;
            }
        }

        private void btn_GdaxOpen_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txt_GdaxPath.Text = openDialog.FileName;
            }
        }

        private void btn_BitfinexImport_Click(object sender, EventArgs e)
        {
            var transactions = FileHandler.BitfinexImport(txt_BitfinexPath.Text);

            for (int i = 0; i < transactions.Count; i++)
            {
                if (_profile.Transactions.Find(t => t.Hash == transactions[i].Hash && t.To == cb_Bitfinex.Text) != null)
                {
                    transactions.RemoveAt(i);
                    i--;
                }
                else
                {
                    transactions[i].From = cb_Bitfinex.Text;
                    transactions[i].To = cb_Bitfinex.Text;
                }
            }

            _profile.Transactions.AddRange(transactions);
            _profile.SortTransactions();
            
            RefreshAccounts();
        }

        private void btn_GdaxImport_Click(object sender, EventArgs e)
        {
            var transactions = FileHandler.GdaxImport(txt_GdaxPath.Text);

            for (int i = 0; i < transactions.Count; i++)
            {
                if (_profile.Transactions.Find(t => t.Hash == transactions[i].Hash && t.To == cb_Gdax.Text) != null)
                {
                    transactions.RemoveAt(i);
                    i--;
                }
                else
                {
                    transactions[i].From = cb_Gdax.Text;
                    transactions[i].To = cb_Gdax.Text;
                }
            }

            _profile.Transactions.AddRange(transactions);
            _profile.SortTransactions();

            RefreshAccounts();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            RefreshAccounts();
        }
    }
}
