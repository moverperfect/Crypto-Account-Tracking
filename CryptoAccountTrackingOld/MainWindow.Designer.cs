namespace CryptoAccountTracking
{
    internal partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ProfileName = new System.Windows.Forms.Label();
            this.lbl_Accounts = new System.Windows.Forms.Label();
            this.dg_Accounts = new System.Windows.Forms.DataGridView();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.dg_Addresses = new System.Windows.Forms.DataGridView();
            this.lbl_Addresses = new System.Windows.Forms.Label();
            this.btn_CreateAddress = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_EditAddress = new System.Windows.Forms.Button();
            this.btn_DeleteAddress = new System.Windows.Forms.Button();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tp_AccountsDetails = new System.Windows.Forms.TabPage();
            this.tc_AddressTransfers = new System.Windows.Forms.TabControl();
            this.tp_Transactions = new System.Windows.Forms.TabPage();
            this.btn_CreateTransaction = new System.Windows.Forms.Button();
            this.btn_DeleteTransaction = new System.Windows.Forms.Button();
            this.btn_EditTransaction = new System.Windows.Forms.Button();
            this.dg_Transactions = new System.Windows.Forms.DataGridView();
            this.tp_Trades = new System.Windows.Forms.TabPage();
            this.btn_CreateTrade = new System.Windows.Forms.Button();
            this.btn_DeleteTrade = new System.Windows.Forms.Button();
            this.btn_EditTrade = new System.Windows.Forms.Button();
            this.dg_Trades = new System.Windows.Forms.DataGridView();
            this.tp_Portfolio = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Addresses)).BeginInit();
            this.tc_Main.SuspendLayout();
            this.tp_AccountsDetails.SuspendLayout();
            this.tc_AddressTransfers.SuspendLayout();
            this.tp_Transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Transactions)).BeginInit();
            this.tp_Trades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Trades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProfileName
            // 
            this.lbl_ProfileName.AutoSize = true;
            this.lbl_ProfileName.Location = new System.Drawing.Point(13, 13);
            this.lbl_ProfileName.Name = "lbl_ProfileName";
            this.lbl_ProfileName.Size = new System.Drawing.Size(42, 13);
            this.lbl_ProfileName.TabIndex = 0;
            this.lbl_ProfileName.Text = "Profile: ";
            // 
            // lbl_Accounts
            // 
            this.lbl_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Accounts.AutoSize = true;
            this.lbl_Accounts.Location = new System.Drawing.Point(6, 3);
            this.lbl_Accounts.Name = "lbl_Accounts";
            this.lbl_Accounts.Size = new System.Drawing.Size(55, 13);
            this.lbl_Accounts.TabIndex = 2;
            this.lbl_Accounts.Text = "Accounts:";
            // 
            // dg_Accounts
            // 
            this.dg_Accounts.AllowUserToAddRows = false;
            this.dg_Accounts.AllowUserToDeleteRows = false;
            this.dg_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Accounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Accounts.Location = new System.Drawing.Point(6, 19);
            this.dg_Accounts.MultiSelect = false;
            this.dg_Accounts.Name = "dg_Accounts";
            this.dg_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Accounts.ShowEditingIcon = false;
            this.dg_Accounts.Size = new System.Drawing.Size(456, 563);
            this.dg_Accounts.TabIndex = 1;
            this.dg_Accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Accounts_CellClick);
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CreateAccount.Location = new System.Drawing.Point(364, 588);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(98, 23);
            this.btn_CreateAccount.TabIndex = 3;
            this.btn_CreateAccount.Text = "Create Account";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // dg_Addresses
            // 
            this.dg_Addresses.AllowUserToAddRows = false;
            this.dg_Addresses.AllowUserToDeleteRows = false;
            this.dg_Addresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Addresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Addresses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Addresses.Location = new System.Drawing.Point(468, 19);
            this.dg_Addresses.MultiSelect = false;
            this.dg_Addresses.Name = "dg_Addresses";
            this.dg_Addresses.ReadOnly = true;
            this.dg_Addresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Addresses.Size = new System.Drawing.Size(696, 209);
            this.dg_Addresses.TabIndex = 4;
            this.dg_Addresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Addresses_CellClick);
            // 
            // lbl_Addresses
            // 
            this.lbl_Addresses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Addresses.AutoSize = true;
            this.lbl_Addresses.Location = new System.Drawing.Point(465, 3);
            this.lbl_Addresses.Name = "lbl_Addresses";
            this.lbl_Addresses.Size = new System.Drawing.Size(56, 13);
            this.lbl_Addresses.TabIndex = 5;
            this.lbl_Addresses.Text = "Addresses";
            // 
            // btn_CreateAddress
            // 
            this.btn_CreateAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateAddress.Location = new System.Drawing.Point(1072, 234);
            this.btn_CreateAddress.Name = "btn_CreateAddress";
            this.btn_CreateAddress.Size = new System.Drawing.Size(92, 23);
            this.btn_CreateAddress.TabIndex = 6;
            this.btn_CreateAddress.Text = "Create Address";
            this.btn_CreateAddress.UseVisualStyleBackColor = true;
            this.btn_CreateAddress.Click += new System.EventHandler(this.btn_CreateAddress_Click);
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditAccount.Location = new System.Drawing.Point(275, 588);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(83, 23);
            this.btn_EditAccount.TabIndex = 7;
            this.btn_EditAccount.Text = "Edit Account";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            this.btn_EditAccount.Click += new System.EventHandler(this.btn_EditAccount_Click);
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteAccount.Location = new System.Drawing.Point(174, 588);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(95, 23);
            this.btn_DeleteAccount.TabIndex = 8;
            this.btn_DeleteAccount.Text = "Delete Account";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            this.btn_DeleteAccount.Click += new System.EventHandler(this.btn_DeleteAccount_Click);
            // 
            // btn_EditAddress
            // 
            this.btn_EditAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditAddress.Location = new System.Drawing.Point(988, 234);
            this.btn_EditAddress.Name = "btn_EditAddress";
            this.btn_EditAddress.Size = new System.Drawing.Size(78, 23);
            this.btn_EditAddress.TabIndex = 9;
            this.btn_EditAddress.Text = "Edit Address";
            this.btn_EditAddress.UseVisualStyleBackColor = true;
            this.btn_EditAddress.Click += new System.EventHandler(this.btn_EditAddress_Click);
            // 
            // btn_DeleteAddress
            // 
            this.btn_DeleteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteAddress.Location = new System.Drawing.Point(890, 234);
            this.btn_DeleteAddress.Name = "btn_DeleteAddress";
            this.btn_DeleteAddress.Size = new System.Drawing.Size(92, 23);
            this.btn_DeleteAddress.TabIndex = 10;
            this.btn_DeleteAddress.Text = "Delete Address";
            this.btn_DeleteAddress.UseVisualStyleBackColor = true;
            this.btn_DeleteAddress.Click += new System.EventHandler(this.btn_DeleteAddress_Click);
            // 
            // tc_Main
            // 
            this.tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Main.Controls.Add(this.tp_AccountsDetails);
            this.tc_Main.Controls.Add(this.tp_Portfolio);
            this.tc_Main.Location = new System.Drawing.Point(12, 29);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(1180, 644);
            this.tc_Main.TabIndex = 11;
            // 
            // tp_AccountsDetails
            // 
            this.tp_AccountsDetails.Controls.Add(this.tc_AddressTransfers);
            this.tp_AccountsDetails.Controls.Add(this.dg_Addresses);
            this.tp_AccountsDetails.Controls.Add(this.btn_DeleteAddress);
            this.tp_AccountsDetails.Controls.Add(this.btn_CreateAccount);
            this.tp_AccountsDetails.Controls.Add(this.btn_EditAddress);
            this.tp_AccountsDetails.Controls.Add(this.dg_Accounts);
            this.tp_AccountsDetails.Controls.Add(this.btn_DeleteAccount);
            this.tp_AccountsDetails.Controls.Add(this.lbl_Accounts);
            this.tp_AccountsDetails.Controls.Add(this.btn_EditAccount);
            this.tp_AccountsDetails.Controls.Add(this.lbl_Addresses);
            this.tp_AccountsDetails.Controls.Add(this.btn_CreateAddress);
            this.tp_AccountsDetails.Location = new System.Drawing.Point(4, 22);
            this.tp_AccountsDetails.Name = "tp_AccountsDetails";
            this.tp_AccountsDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AccountsDetails.Size = new System.Drawing.Size(1172, 618);
            this.tp_AccountsDetails.TabIndex = 0;
            this.tp_AccountsDetails.Text = "Accounts Details";
            this.tp_AccountsDetails.UseVisualStyleBackColor = true;
            // 
            // tc_AddressTransfers
            // 
            this.tc_AddressTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_AddressTransfers.Controls.Add(this.tp_Transactions);
            this.tc_AddressTransfers.Controls.Add(this.tp_Trades);
            this.tc_AddressTransfers.Location = new System.Drawing.Point(468, 263);
            this.tc_AddressTransfers.Name = "tc_AddressTransfers";
            this.tc_AddressTransfers.SelectedIndex = 0;
            this.tc_AddressTransfers.Size = new System.Drawing.Size(696, 348);
            this.tc_AddressTransfers.TabIndex = 11;
            // 
            // tp_Transactions
            // 
            this.tp_Transactions.Controls.Add(this.btn_CreateTransaction);
            this.tp_Transactions.Controls.Add(this.btn_DeleteTransaction);
            this.tp_Transactions.Controls.Add(this.btn_EditTransaction);
            this.tp_Transactions.Controls.Add(this.dg_Transactions);
            this.tp_Transactions.Location = new System.Drawing.Point(4, 22);
            this.tp_Transactions.Name = "tp_Transactions";
            this.tp_Transactions.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Transactions.Size = new System.Drawing.Size(688, 322);
            this.tp_Transactions.TabIndex = 0;
            this.tp_Transactions.Text = "Transactions";
            this.tp_Transactions.UseVisualStyleBackColor = true;
            // 
            // btn_CreateTransaction
            // 
            this.btn_CreateTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateTransaction.Location = new System.Drawing.Point(576, 293);
            this.btn_CreateTransaction.Name = "btn_CreateTransaction";
            this.btn_CreateTransaction.Size = new System.Drawing.Size(106, 23);
            this.btn_CreateTransaction.TabIndex = 9;
            this.btn_CreateTransaction.Text = "Create Transaction";
            this.btn_CreateTransaction.UseVisualStyleBackColor = true;
            this.btn_CreateTransaction.Click += new System.EventHandler(this.btn_CreateTransaction_Click);
            // 
            // btn_DeleteTransaction
            // 
            this.btn_DeleteTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteTransaction.Location = new System.Drawing.Point(355, 293);
            this.btn_DeleteTransaction.Name = "btn_DeleteTransaction";
            this.btn_DeleteTransaction.Size = new System.Drawing.Size(109, 23);
            this.btn_DeleteTransaction.TabIndex = 11;
            this.btn_DeleteTransaction.Text = "Delete Transaction";
            this.btn_DeleteTransaction.UseVisualStyleBackColor = true;
            this.btn_DeleteTransaction.Click += new System.EventHandler(this.btn_DeleteTransaction_Click);
            // 
            // btn_EditTransaction
            // 
            this.btn_EditTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditTransaction.Location = new System.Drawing.Point(470, 293);
            this.btn_EditTransaction.Name = "btn_EditTransaction";
            this.btn_EditTransaction.Size = new System.Drawing.Size(100, 23);
            this.btn_EditTransaction.TabIndex = 10;
            this.btn_EditTransaction.Text = "Edit Transaction";
            this.btn_EditTransaction.UseVisualStyleBackColor = true;
            this.btn_EditTransaction.Click += new System.EventHandler(this.btn_EditTransaction_Click);
            // 
            // dg_Transactions
            // 
            this.dg_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Transactions.Location = new System.Drawing.Point(7, 7);
            this.dg_Transactions.Name = "dg_Transactions";
            this.dg_Transactions.Size = new System.Drawing.Size(675, 280);
            this.dg_Transactions.TabIndex = 0;
            // 
            // tp_Trades
            // 
            this.tp_Trades.Controls.Add(this.btn_CreateTrade);
            this.tp_Trades.Controls.Add(this.btn_DeleteTrade);
            this.tp_Trades.Controls.Add(this.btn_EditTrade);
            this.tp_Trades.Controls.Add(this.dg_Trades);
            this.tp_Trades.Location = new System.Drawing.Point(4, 22);
            this.tp_Trades.Name = "tp_Trades";
            this.tp_Trades.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Trades.Size = new System.Drawing.Size(688, 322);
            this.tp_Trades.TabIndex = 1;
            this.tp_Trades.Text = "Trades";
            this.tp_Trades.UseVisualStyleBackColor = true;
            // 
            // btn_CreateTrade
            // 
            this.btn_CreateTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateTrade.Location = new System.Drawing.Point(598, 293);
            this.btn_CreateTrade.Name = "btn_CreateTrade";
            this.btn_CreateTrade.Size = new System.Drawing.Size(84, 23);
            this.btn_CreateTrade.TabIndex = 9;
            this.btn_CreateTrade.Text = "Create Trade";
            this.btn_CreateTrade.UseVisualStyleBackColor = true;
            this.btn_CreateTrade.Click += new System.EventHandler(this.Btn_CreateTrade_Click);
            // 
            // btn_DeleteTrade
            // 
            this.btn_DeleteTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteTrade.Location = new System.Drawing.Point(427, 293);
            this.btn_DeleteTrade.Name = "btn_DeleteTrade";
            this.btn_DeleteTrade.Size = new System.Drawing.Size(84, 23);
            this.btn_DeleteTrade.TabIndex = 11;
            this.btn_DeleteTrade.Text = "Delete Trade";
            this.btn_DeleteTrade.UseVisualStyleBackColor = true;
            this.btn_DeleteTrade.Click += new System.EventHandler(this.Btn_DeleteTrade_Click);
            // 
            // btn_EditTrade
            // 
            this.btn_EditTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditTrade.Location = new System.Drawing.Point(517, 293);
            this.btn_EditTrade.Name = "btn_EditTrade";
            this.btn_EditTrade.Size = new System.Drawing.Size(75, 23);
            this.btn_EditTrade.TabIndex = 10;
            this.btn_EditTrade.Text = "Edit Trade";
            this.btn_EditTrade.UseVisualStyleBackColor = true;
            this.btn_EditTrade.Click += new System.EventHandler(this.Btn_EditTrade_Click);
            // 
            // dg_Trades
            // 
            this.dg_Trades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Trades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Trades.Location = new System.Drawing.Point(7, 7);
            this.dg_Trades.Name = "dg_Trades";
            this.dg_Trades.Size = new System.Drawing.Size(675, 280);
            this.dg_Trades.TabIndex = 0;
            // 
            // tp_Portfolio
            // 
            this.tp_Portfolio.Location = new System.Drawing.Point(4, 22);
            this.tp_Portfolio.Name = "tp_Portfolio";
            this.tp_Portfolio.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Portfolio.Size = new System.Drawing.Size(1172, 618);
            this.tp_Portfolio.TabIndex = 1;
            this.tp_Portfolio.Text = "Portfolio";
            this.tp_Portfolio.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 674);
            this.Controls.Add(this.tc_Main);
            this.Controls.Add(this.lbl_ProfileName);
            this.Name = "MainWindow";
            this.Text = "Crypto Account Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Addresses)).EndInit();
            this.tc_Main.ResumeLayout(false);
            this.tp_AccountsDetails.ResumeLayout(false);
            this.tp_AccountsDetails.PerformLayout();
            this.tc_AddressTransfers.ResumeLayout(false);
            this.tp_Transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Transactions)).EndInit();
            this.tp_Trades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Trades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProfileName;
        private System.Windows.Forms.Label lbl_Accounts;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.DataGridView dg_Accounts;
        private System.Windows.Forms.DataGridView dg_Addresses;
        private System.Windows.Forms.Label lbl_Addresses;
        private System.Windows.Forms.Button btn_CreateAddress;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_EditAddress;
        private System.Windows.Forms.Button btn_DeleteAddress;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tp_AccountsDetails;
        private System.Windows.Forms.TabPage tp_Portfolio;
        private System.Windows.Forms.TabControl tc_AddressTransfers;
        private System.Windows.Forms.TabPage tp_Transactions;
        private System.Windows.Forms.Button btn_CreateTransaction;
        private System.Windows.Forms.Button btn_DeleteTransaction;
        private System.Windows.Forms.Button btn_EditTransaction;
        private System.Windows.Forms.DataGridView dg_Transactions;
        private System.Windows.Forms.TabPage tp_Trades;
        private System.Windows.Forms.Button btn_CreateTrade;
        private System.Windows.Forms.Button btn_DeleteTrade;
        private System.Windows.Forms.Button btn_EditTrade;
        private System.Windows.Forms.DataGridView dg_Trades;
    }
}