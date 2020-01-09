using System;
using System.Linq;
using System.Windows.Forms;

namespace CryptoAccountTracking
{
    internal partial class MainWindow : Form
    {
        private Account SelectedAccount;

        private NetAddress SelectedAddress;

        internal MainWindow()
        {
            InitializeComponent();

            lbl_ProfileName.Text = "Profile: " + Program.MainProfile.ProfileName;

            // Set Accounts Table
            dg_Accounts.Columns.Add("Name", "Account Name");
            dg_Accounts.Columns.Add("Notes", "Account Notes");

            // Set Address Table
            dg_Addresses.Columns.Add("AddressName", "Address Name");
            dg_Addresses.Columns.Add("ISO", "Currency ISO");
            dg_Addresses.Columns["ISO"].Visible = false;
            dg_Addresses.Columns.Add("Currency", "Currency Name");
            dg_Addresses.Columns.Add("Holdings", "Holdings");
            dg_Addresses.Columns.Add("Address", "Address");

            // Set Transaction Table
            dg_Transactions.Columns.Add("Date", "Date");
            dg_Transactions.Columns.Add("From", "From");
            dg_Transactions.Columns.Add("To", "To");
            dg_Transactions.Columns.Add("Amount", "Amount");
            dg_Transactions.Columns.Add("Fee", "Fee");
            dg_Transactions.Columns.Add("TransactionHash", "Transaction Hash");

            // Refresh all of the tables
            RefreshAccountsTable();
        }

        private void RefreshAccountsTable()
        {
            dg_Accounts.Rows.Clear();
            foreach (var account in Program.MainProfile.Accounts)
            {
                dg_Accounts.Rows.Add(account.Name, account.Notes);
            }

            if (dg_Accounts.Rows.Count > 0)
            {
                dg_Accounts.Rows[0].Selected = true;
                SelectedAccount = Program.MainProfile.Accounts.Find(t => t.Name == (string)dg_Accounts.SelectedRows[0].Cells[0].Value);
            }

            dg_Accounts_CellClick(null, null);
        }

        private void dg_Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_Addresses.Rows.Clear();
            if (dg_Accounts.SelectedRows.Count <= 0) return;

            foreach (var address in SelectedAccount.Addresses)
            {
                dg_Addresses.Rows.Add(address.AddressName, address.Currency.IsoName, address.Currency.Name,
                    address.HoldingsAtDate(DateTime.Now), address.Address);
            }

            if (dg_Addresses.Rows.Count > 0)
            {
                dg_Addresses.Rows[0].Selected = true;
                SelectedAddress = SelectedAccount.Addresses.Find(t => t.AddressName == (string)dg_Addresses.SelectedRows[0].Cells[0].Value);
            }

            dg_Addresses_CellClick(null, null);
        }

        private void dg_Addresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_Transactions.Rows.Clear();
            if (dg_Addresses.SelectedRows.Count <= 0) return;

            foreach (var transfer in SelectedAddress.Transfers)
            {
                dg_Transactions.Rows.Add(transfer.Date, transfer.From, transfer.To, transfer.Amount,
                    transfer.Fee, transfer.TransactionHash);
            }

            if (dg_Transactions.Rows.Count > 0) dg_Transactions.Rows[0].Selected = true;
        }

        #region Account Buttons
        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            var editAccount = new EditAccount();
            var result = editAccount.ShowDialog();
            if (result != DialogResult.OK) return;

            if (Program.MainProfile.Accounts.Find(t => t.Name == editAccount.txt_Name.Text) != null)
            {
                MessageBox.Show("This account name already exists", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Program.MainProfile.Accounts.Add(new Account() { Name = editAccount.txt_Name.Text, Notes = editAccount.txt_Notes.Text });
            RefreshAccountsTable();
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            if (dg_Accounts.SelectedRows.Count <= 0) return;
            var editAccount = new EditAccount((string)dg_Accounts.SelectedRows[0].Cells[0].Value, (string)dg_Accounts.SelectedRows[0].Cells[1].Value);
            var result = editAccount.ShowDialog();

            if (result != DialogResult.OK) return;

            foreach (var account in Program.MainProfile.Accounts)
            {
                if (account.Name == (string) dg_Accounts.SelectedRows[0].Cells[0].Value)
                {
                    // If the name has changed and it equals a name that already exists then error out
                    while (account.Name != editAccount.txt_Name.Text && Program.MainProfile.Accounts.Find(t => t.Name == editAccount.txt_Name.Text) != null)
                    {
                        MessageBox.Show("This account name already exists", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        result = editAccount.ShowDialog();
                        if (result != DialogResult.OK) return;
                    }
                    account.Name = editAccount.txt_Name.Text;
                    account.Notes = editAccount.txt_Notes.Text;
                    break;
                }
            }

            RefreshAccountsTable();
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the Account", "Are you sure?",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Program.MainProfile.Accounts.Remove(Program.MainProfile.Accounts.Find(t =>
                    t.Name == (string)dg_Accounts.SelectedRows[0].Cells[0].Value));
                RefreshAccountsTable();
            }
        }
        #endregion

        #region Address Buttons
        private void btn_CreateAddress_Click(object sender, EventArgs e)
        {
            var editAddress = new EditAddress(Program.MainProfile.Currencies);
            var result = editAddress.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var account in Program.MainProfile.Accounts)
                {
                    if (account.Name == (string)dg_Accounts.SelectedRows[0].Cells[0].Value)
                    {
                        account.Addresses.Add(new NetAddress()
                        {
                            AddressName = editAddress.txt_AddressName.Text,
                            Address = editAddress.txt_Address.Text,
                            Currency = new NetCurrency
                            {
                                IsoName = (string) editAddress.dg_Currencies.SelectedRows[0].Cells[0].Value,
                                Name = (string) editAddress.dg_Currencies.SelectedRows[0].Cells[1].Value
                            }
                        });
                    }
                }

                dg_Accounts_CellClick(null, null);
            }
        }

        private void btn_EditAddress_Click(object sender, EventArgs e)
        {
            if (dg_Addresses.SelectedRows.Count <= 0) return;
            var editAddress = new EditAddress(Program.MainProfile.Currencies,
                (string) dg_Addresses.SelectedRows[0].Cells["AddressName"].Value,
                (string) dg_Addresses.SelectedRows[0].Cells["Address"].Value,
                (string) dg_Addresses.SelectedRows[0].Cells["ISO"].Value);
            var result = editAddress.ShowDialog();

            if (result != DialogResult.OK) return;

            foreach (var account in Program.MainProfile.Accounts)
            {
                if (account.Name == (string) dg_Accounts.SelectedRows[0].Cells[0].Value)
                {
                    foreach (var address in account.Addresses)
                    {
                        if (address.AddressName == (string) dg_Addresses.SelectedRows[0].Cells["AddressName"].Value)
                        {
                            // If the name has changed and it equals a name that already exists then error out
                            while (address.AddressName != editAddress.txt_AddressName.Text &&
                                   account.Addresses.Find(t => t.AddressName == editAddress.txt_AddressName.Text) !=
                                   null)
                            {
                                MessageBox.Show("This address name already exists", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                result = editAddress.ShowDialog();
                                if (result != DialogResult.OK) return;
                            }

                            address.AddressName = editAddress.txt_AddressName.Text;
                            address.Address = editAddress.txt_Address.Text;
                            address.Currency = new NetCurrency
                            {
                                IsoName = (string) editAddress.dg_Currencies.SelectedRows[0].Cells["ISO"].Value,
                                Name = (string) editAddress.dg_Currencies.SelectedRows[0].Cells["Name"].Value
                            };
                            break;
                        }
                    }
                }
            }

            RefreshAccountsTable();
        }

        private void btn_DeleteAddress_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the Address", "Are you sure?",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var addresses = Program.MainProfile.Accounts
                    .Find(t => t.Name == (string) dg_Accounts.SelectedRows[0].Cells["Name"].Value).Addresses;
                addresses.Remove(addresses.Find(t =>
                    t.AddressName == (string) dg_Addresses.SelectedRows[0].Cells["AddressName"].Value));
                RefreshAccountsTable();
            }
        }
        #endregion

        #region Transaction Buttons
        private void btn_CreateTransaction_Click(object sender, EventArgs e)
        {
            var addressList = Program.MainProfile.AddressList;

            var currentIso = SelectedAddress.Currency.IsoName;
            addressList.RemoveAll(t => t.Address.Currency.IsoName != currentIso);

            addressList.Insert(0,
                new AccountAddress
                {
                    Account = new Account {Name = "External"}, Address = new NetAddress {AddressName = "External"}
                });

            var selectedIndex = addressList.FindIndex(t =>
                t.Account.Name == SelectedAccount.Name && t.Address.AddressName ==
                SelectedAddress.AddressName);

            var editTransaction = new EditTransaction(addressList, selectedIndex);
            var result = editTransaction.ShowDialog();
            var transResult = editTransaction.Transaction;

            if (result != DialogResult.OK) return;

            if (transResult.From != "External : External")
            {
                var tempAddress = Program.MainProfile.Accounts.Find(t => t.Name == transResult.From.Split(new[] { " : " }, StringSplitOptions.None)[0]).Addresses.Find(t => t.AddressName == transResult.From.Split(new[] { " : " }, StringSplitOptions.None)[1]);
                var tempResult = transResult;

                tempAddress.Transfers.Add(tempResult);
                tempAddress.Transfers[tempAddress.Transfers.Count - 1].From = transResult.From.Split(new[] { " : " }, StringSplitOptions.None)[1];

                tempAddress.SortTransactions();
            }

            if (transResult.To != "External : External")
            {
                var tempAddress = Program.MainProfile.Accounts.Find(t => t.Name == transResult.To.Split(new[] { " : " }, StringSplitOptions.None)[0]).Addresses.Find(t => t.AddressName == transResult.To.Split(new[] { " : " }, StringSplitOptions.None)[1]);
                var tempResult = transResult;

                tempAddress.Transfers.Add(tempResult);
                tempAddress.Transfers[tempAddress.Transfers.Count - 1].To = transResult.To.Split(new[] { " : " }, StringSplitOptions.None)[1];

                tempAddress.SortTransactions();
            }

            RefreshAccountsTable();
        }

        private void btn_EditTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteTransaction_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Trade Buttons
        private void Btn_CreateTrade_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_EditTrade_Click(object sender, EventArgs e)
        {

        }

        private void Btn_DeleteTrade_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
