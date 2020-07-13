namespace CryptoAccountTracking.Forms
{
    partial class MainWindow
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
            this.lbl_Profile = new System.Windows.Forms.Label();
            this.btn_CreateProfile = new System.Windows.Forms.Button();
            this.btn_LoadProfile = new System.Windows.Forms.Button();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tp_Accounts = new System.Windows.Forms.TabPage();
            this.cb_CurrencyFilter = new System.Windows.Forms.ComboBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.tc_Transactions = new System.Windows.Forms.TabControl();
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
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.dg_Balance = new System.Windows.Forms.DataGridView();
            this.lbl_Accounts = new System.Windows.Forms.Label();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_EditAccount = new System.Windows.Forms.Button();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.dg_Accounts = new System.Windows.Forms.DataGridView();
            this.tp_TotalPortfolio = new System.Windows.Forms.TabPage();
            this.dg_CurrencyLocation = new System.Windows.Forms.DataGridView();
            this.dg_TotalPortfolio = new System.Windows.Forms.DataGridView();
            this.tp_Import = new System.Windows.Forms.TabPage();
            this.btn_GdaxImport = new System.Windows.Forms.Button();
            this.cb_Gdax = new System.Windows.Forms.ComboBox();
            this.btn_GdaxOpen = new System.Windows.Forms.Button();
            this.txt_GdaxPath = new System.Windows.Forms.TextBox();
            this.lbl_Gdax = new System.Windows.Forms.Label();
            this.btn_BitfinexImport = new System.Windows.Forms.Button();
            this.cb_Bitfinex = new System.Windows.Forms.ComboBox();
            this.btn_BitfinexOpen = new System.Windows.Forms.Button();
            this.txt_BitfinexPath = new System.Windows.Forms.TextBox();
            this.lbl_Bitfinex = new System.Windows.Forms.Label();
            this.tp_Settings = new System.Windows.Forms.TabPage();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.ofd_Profile = new System.Windows.Forms.OpenFileDialog();
            this.btn_RefreshPrices = new System.Windows.Forms.Button();
            this.lbl_TotalHoldings = new System.Windows.Forms.Label();
            this.tc_Main.SuspendLayout();
            this.tp_Accounts.SuspendLayout();
            this.tc_Transactions.SuspendLayout();
            this.tp_Transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Transactions)).BeginInit();
            this.tp_Trades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Trades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Accounts)).BeginInit();
            this.tp_TotalPortfolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CurrencyLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_TotalPortfolio)).BeginInit();
            this.tp_Import.SuspendLayout();
            this.tp_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Profile
            // 
            this.lbl_Profile.AutoSize = true;
            this.lbl_Profile.Location = new System.Drawing.Point(13, 13);
            this.lbl_Profile.Name = "lbl_Profile";
            this.lbl_Profile.Size = new System.Drawing.Size(42, 13);
            this.lbl_Profile.TabIndex = 0;
            this.lbl_Profile.Text = "Profile: ";
            // 
            // btn_CreateProfile
            // 
            this.btn_CreateProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateProfile.Location = new System.Drawing.Point(1096, 13);
            this.btn_CreateProfile.Name = "btn_CreateProfile";
            this.btn_CreateProfile.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateProfile.TabIndex = 1;
            this.btn_CreateProfile.Text = "Create Profile";
            this.btn_CreateProfile.UseVisualStyleBackColor = true;
            this.btn_CreateProfile.Click += new System.EventHandler(this.btn_CreateProfile_Click);
            // 
            // btn_LoadProfile
            // 
            this.btn_LoadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadProfile.Location = new System.Drawing.Point(1177, 12);
            this.btn_LoadProfile.Name = "btn_LoadProfile";
            this.btn_LoadProfile.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadProfile.TabIndex = 2;
            this.btn_LoadProfile.Text = "Load Profile";
            this.btn_LoadProfile.UseVisualStyleBackColor = true;
            this.btn_LoadProfile.Click += new System.EventHandler(this.btn_LoadProfile_Click);
            // 
            // tc_Main
            // 
            this.tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Main.Controls.Add(this.tp_Accounts);
            this.tc_Main.Controls.Add(this.tp_TotalPortfolio);
            this.tc_Main.Controls.Add(this.tp_Import);
            this.tc_Main.Controls.Add(this.tp_Settings);
            this.tc_Main.Location = new System.Drawing.Point(16, 42);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(1236, 627);
            this.tc_Main.TabIndex = 3;
            // 
            // tp_Accounts
            // 
            this.tp_Accounts.Controls.Add(this.cb_CurrencyFilter);
            this.tp_Accounts.Controls.Add(this.btn_Filter);
            this.tp_Accounts.Controls.Add(this.tc_Transactions);
            this.tp_Accounts.Controls.Add(this.lbl_Balance);
            this.tp_Accounts.Controls.Add(this.dg_Balance);
            this.tp_Accounts.Controls.Add(this.lbl_Accounts);
            this.tp_Accounts.Controls.Add(this.btn_DeleteAccount);
            this.tp_Accounts.Controls.Add(this.btn_EditAccount);
            this.tp_Accounts.Controls.Add(this.btn_CreateAccount);
            this.tp_Accounts.Controls.Add(this.dg_Accounts);
            this.tp_Accounts.Location = new System.Drawing.Point(4, 22);
            this.tp_Accounts.Name = "tp_Accounts";
            this.tp_Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Accounts.Size = new System.Drawing.Size(1228, 601);
            this.tp_Accounts.TabIndex = 0;
            this.tp_Accounts.Text = "Accounts";
            this.tp_Accounts.UseVisualStyleBackColor = true;
            // 
            // cb_CurrencyFilter
            // 
            this.cb_CurrencyFilter.FormattingEnabled = true;
            this.cb_CurrencyFilter.Location = new System.Drawing.Point(1016, 251);
            this.cb_CurrencyFilter.Name = "cb_CurrencyFilter";
            this.cb_CurrencyFilter.Size = new System.Drawing.Size(121, 21);
            this.cb_CurrencyFilter.TabIndex = 4;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(1143, 251);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 23);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // tc_Transactions
            // 
            this.tc_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Transactions.Controls.Add(this.tp_Transactions);
            this.tc_Transactions.Controls.Add(this.tp_Trades);
            this.tc_Transactions.Location = new System.Drawing.Point(621, 256);
            this.tc_Transactions.Name = "tc_Transactions";
            this.tc_Transactions.SelectedIndex = 0;
            this.tc_Transactions.Size = new System.Drawing.Size(601, 339);
            this.tc_Transactions.TabIndex = 7;
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
            this.tp_Transactions.Size = new System.Drawing.Size(593, 313);
            this.tp_Transactions.TabIndex = 0;
            this.tp_Transactions.Text = "Transactions";
            this.tp_Transactions.UseVisualStyleBackColor = true;
            // 
            // btn_CreateTransaction
            // 
            this.btn_CreateTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateTransaction.Enabled = false;
            this.btn_CreateTransaction.Location = new System.Drawing.Point(481, 286);
            this.btn_CreateTransaction.Name = "btn_CreateTransaction";
            this.btn_CreateTransaction.Size = new System.Drawing.Size(106, 23);
            this.btn_CreateTransaction.TabIndex = 13;
            this.btn_CreateTransaction.Text = "Create Transaction";
            this.btn_CreateTransaction.UseVisualStyleBackColor = true;
            this.btn_CreateTransaction.Click += new System.EventHandler(this.btn_CreateTransaction_Click);
            // 
            // btn_DeleteTransaction
            // 
            this.btn_DeleteTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteTransaction.Enabled = false;
            this.btn_DeleteTransaction.Location = new System.Drawing.Point(260, 286);
            this.btn_DeleteTransaction.Name = "btn_DeleteTransaction";
            this.btn_DeleteTransaction.Size = new System.Drawing.Size(109, 23);
            this.btn_DeleteTransaction.TabIndex = 15;
            this.btn_DeleteTransaction.Text = "Delete Transaction";
            this.btn_DeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // btn_EditTransaction
            // 
            this.btn_EditTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditTransaction.Enabled = false;
            this.btn_EditTransaction.Location = new System.Drawing.Point(375, 286);
            this.btn_EditTransaction.Name = "btn_EditTransaction";
            this.btn_EditTransaction.Size = new System.Drawing.Size(100, 23);
            this.btn_EditTransaction.TabIndex = 14;
            this.btn_EditTransaction.Text = "Edit Transaction";
            this.btn_EditTransaction.UseVisualStyleBackColor = true;
            // 
            // dg_Transactions
            // 
            this.dg_Transactions.AllowUserToAddRows = false;
            this.dg_Transactions.AllowUserToDeleteRows = false;
            this.dg_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Transactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Transactions.Location = new System.Drawing.Point(6, 6);
            this.dg_Transactions.MultiSelect = false;
            this.dg_Transactions.Name = "dg_Transactions";
            this.dg_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Transactions.Size = new System.Drawing.Size(581, 274);
            this.dg_Transactions.TabIndex = 12;
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
            this.tp_Trades.Size = new System.Drawing.Size(593, 313);
            this.tp_Trades.TabIndex = 1;
            this.tp_Trades.Text = "Trades";
            this.tp_Trades.UseVisualStyleBackColor = true;
            // 
            // btn_CreateTrade
            // 
            this.btn_CreateTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateTrade.Enabled = false;
            this.btn_CreateTrade.Location = new System.Drawing.Point(503, 286);
            this.btn_CreateTrade.Name = "btn_CreateTrade";
            this.btn_CreateTrade.Size = new System.Drawing.Size(84, 23);
            this.btn_CreateTrade.TabIndex = 13;
            this.btn_CreateTrade.Text = "Create Trade";
            this.btn_CreateTrade.UseVisualStyleBackColor = true;
            this.btn_CreateTrade.Click += new System.EventHandler(this.btn_CreateTrade_Click);
            // 
            // btn_DeleteTrade
            // 
            this.btn_DeleteTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteTrade.Enabled = false;
            this.btn_DeleteTrade.Location = new System.Drawing.Point(332, 286);
            this.btn_DeleteTrade.Name = "btn_DeleteTrade";
            this.btn_DeleteTrade.Size = new System.Drawing.Size(84, 23);
            this.btn_DeleteTrade.TabIndex = 15;
            this.btn_DeleteTrade.Text = "Delete Trade";
            this.btn_DeleteTrade.UseVisualStyleBackColor = true;
            // 
            // btn_EditTrade
            // 
            this.btn_EditTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditTrade.Enabled = false;
            this.btn_EditTrade.Location = new System.Drawing.Point(422, 286);
            this.btn_EditTrade.Name = "btn_EditTrade";
            this.btn_EditTrade.Size = new System.Drawing.Size(75, 23);
            this.btn_EditTrade.TabIndex = 14;
            this.btn_EditTrade.Text = "Edit Trade";
            this.btn_EditTrade.UseVisualStyleBackColor = true;
            // 
            // dg_Trades
            // 
            this.dg_Trades.AllowUserToAddRows = false;
            this.dg_Trades.AllowUserToDeleteRows = false;
            this.dg_Trades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Trades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Trades.Location = new System.Drawing.Point(6, 6);
            this.dg_Trades.Name = "dg_Trades";
            this.dg_Trades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Trades.Size = new System.Drawing.Size(581, 274);
            this.dg_Trades.TabIndex = 12;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(620, 3);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(52, 13);
            this.lbl_Balance.TabIndex = 6;
            this.lbl_Balance.Text = "Balance: ";
            // 
            // dg_Balance
            // 
            this.dg_Balance.AllowUserToAddRows = false;
            this.dg_Balance.AllowUserToDeleteRows = false;
            this.dg_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Balance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Balance.Location = new System.Drawing.Point(621, 19);
            this.dg_Balance.MultiSelect = false;
            this.dg_Balance.Name = "dg_Balance";
            this.dg_Balance.ReadOnly = true;
            this.dg_Balance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Balance.Size = new System.Drawing.Size(601, 230);
            this.dg_Balance.TabIndex = 5;
            // 
            // lbl_Accounts
            // 
            this.lbl_Accounts.AutoSize = true;
            this.lbl_Accounts.Location = new System.Drawing.Point(6, 3);
            this.lbl_Accounts.Name = "lbl_Accounts";
            this.lbl_Accounts.Size = new System.Drawing.Size(55, 13);
            this.lbl_Accounts.TabIndex = 4;
            this.lbl_Accounts.Text = "Accounts:";
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteAccount.Enabled = false;
            this.btn_DeleteAccount.Location = new System.Drawing.Point(339, 572);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(91, 23);
            this.btn_DeleteAccount.TabIndex = 3;
            this.btn_DeleteAccount.Text = "Delete Account";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btn_EditAccount
            // 
            this.btn_EditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditAccount.Enabled = false;
            this.btn_EditAccount.Location = new System.Drawing.Point(436, 572);
            this.btn_EditAccount.Name = "btn_EditAccount";
            this.btn_EditAccount.Size = new System.Drawing.Size(85, 23);
            this.btn_EditAccount.TabIndex = 2;
            this.btn_EditAccount.Text = "Edit Account";
            this.btn_EditAccount.UseVisualStyleBackColor = true;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CreateAccount.Enabled = false;
            this.btn_CreateAccount.Location = new System.Drawing.Point(527, 572);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(86, 23);
            this.btn_CreateAccount.TabIndex = 1;
            this.btn_CreateAccount.Text = "New Account";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
            // 
            // dg_Accounts
            // 
            this.dg_Accounts.AllowUserToAddRows = false;
            this.dg_Accounts.AllowUserToDeleteRows = false;
            this.dg_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Accounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_Accounts.Location = new System.Drawing.Point(7, 19);
            this.dg_Accounts.MultiSelect = false;
            this.dg_Accounts.Name = "dg_Accounts";
            this.dg_Accounts.ReadOnly = true;
            this.dg_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Accounts.Size = new System.Drawing.Size(607, 547);
            this.dg_Accounts.TabIndex = 0;
            this.dg_Accounts.SelectionChanged += new System.EventHandler(this.dg_Accounts_SelectionChanged);
            // 
            // tp_TotalPortfolio
            // 
            this.tp_TotalPortfolio.Controls.Add(this.dg_CurrencyLocation);
            this.tp_TotalPortfolio.Controls.Add(this.dg_TotalPortfolio);
            this.tp_TotalPortfolio.Location = new System.Drawing.Point(4, 22);
            this.tp_TotalPortfolio.Name = "tp_TotalPortfolio";
            this.tp_TotalPortfolio.Size = new System.Drawing.Size(1228, 601);
            this.tp_TotalPortfolio.TabIndex = 3;
            this.tp_TotalPortfolio.Text = "Total Portfolio";
            this.tp_TotalPortfolio.UseVisualStyleBackColor = true;
            // 
            // dg_CurrencyLocation
            // 
            this.dg_CurrencyLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_CurrencyLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CurrencyLocation.Location = new System.Drawing.Point(810, 3);
            this.dg_CurrencyLocation.Name = "dg_CurrencyLocation";
            this.dg_CurrencyLocation.Size = new System.Drawing.Size(415, 595);
            this.dg_CurrencyLocation.TabIndex = 1;
            // 
            // dg_TotalPortfolio
            // 
            this.dg_TotalPortfolio.AllowUserToAddRows = false;
            this.dg_TotalPortfolio.AllowUserToDeleteRows = false;
            this.dg_TotalPortfolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_TotalPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_TotalPortfolio.Location = new System.Drawing.Point(3, 3);
            this.dg_TotalPortfolio.MultiSelect = false;
            this.dg_TotalPortfolio.Name = "dg_TotalPortfolio";
            this.dg_TotalPortfolio.ReadOnly = true;
            this.dg_TotalPortfolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_TotalPortfolio.Size = new System.Drawing.Size(801, 595);
            this.dg_TotalPortfolio.TabIndex = 0;
            this.dg_TotalPortfolio.SelectionChanged += new System.EventHandler(this.dg_TotalPortfolio_SelectionChanged);
            this.dg_TotalPortfolio.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dg_TotalPortfolio_SortCompare);
            // 
            // tp_Import
            // 
            this.tp_Import.Controls.Add(this.btn_GdaxImport);
            this.tp_Import.Controls.Add(this.cb_Gdax);
            this.tp_Import.Controls.Add(this.btn_GdaxOpen);
            this.tp_Import.Controls.Add(this.txt_GdaxPath);
            this.tp_Import.Controls.Add(this.lbl_Gdax);
            this.tp_Import.Controls.Add(this.btn_BitfinexImport);
            this.tp_Import.Controls.Add(this.cb_Bitfinex);
            this.tp_Import.Controls.Add(this.btn_BitfinexOpen);
            this.tp_Import.Controls.Add(this.txt_BitfinexPath);
            this.tp_Import.Controls.Add(this.lbl_Bitfinex);
            this.tp_Import.Location = new System.Drawing.Point(4, 22);
            this.tp_Import.Name = "tp_Import";
            this.tp_Import.Size = new System.Drawing.Size(1228, 601);
            this.tp_Import.TabIndex = 2;
            this.tp_Import.Text = "Import";
            this.tp_Import.UseVisualStyleBackColor = true;
            // 
            // btn_GdaxImport
            // 
            this.btn_GdaxImport.Location = new System.Drawing.Point(309, 29);
            this.btn_GdaxImport.Name = "btn_GdaxImport";
            this.btn_GdaxImport.Size = new System.Drawing.Size(75, 22);
            this.btn_GdaxImport.TabIndex = 9;
            this.btn_GdaxImport.Text = "Import";
            this.btn_GdaxImport.UseVisualStyleBackColor = true;
            this.btn_GdaxImport.Click += new System.EventHandler(this.btn_GdaxImport_Click);
            // 
            // cb_Gdax
            // 
            this.cb_Gdax.FormattingEnabled = true;
            this.cb_Gdax.Location = new System.Drawing.Point(182, 29);
            this.cb_Gdax.Name = "cb_Gdax";
            this.cb_Gdax.Size = new System.Drawing.Size(121, 21);
            this.cb_Gdax.TabIndex = 8;
            // 
            // btn_GdaxOpen
            // 
            this.btn_GdaxOpen.Location = new System.Drawing.Point(150, 29);
            this.btn_GdaxOpen.Name = "btn_GdaxOpen";
            this.btn_GdaxOpen.Size = new System.Drawing.Size(26, 22);
            this.btn_GdaxOpen.TabIndex = 7;
            this.btn_GdaxOpen.Text = "...";
            this.btn_GdaxOpen.UseVisualStyleBackColor = true;
            this.btn_GdaxOpen.Click += new System.EventHandler(this.btn_GdaxOpen_Click);
            // 
            // txt_GdaxPath
            // 
            this.txt_GdaxPath.Location = new System.Drawing.Point(50, 30);
            this.txt_GdaxPath.Name = "txt_GdaxPath";
            this.txt_GdaxPath.Size = new System.Drawing.Size(100, 20);
            this.txt_GdaxPath.TabIndex = 6;
            // 
            // lbl_Gdax
            // 
            this.lbl_Gdax.AutoSize = true;
            this.lbl_Gdax.Location = new System.Drawing.Point(3, 33);
            this.lbl_Gdax.Name = "lbl_Gdax";
            this.lbl_Gdax.Size = new System.Drawing.Size(37, 13);
            this.lbl_Gdax.TabIndex = 5;
            this.lbl_Gdax.Text = "GDAX";
            // 
            // btn_BitfinexImport
            // 
            this.btn_BitfinexImport.Location = new System.Drawing.Point(309, 2);
            this.btn_BitfinexImport.Name = "btn_BitfinexImport";
            this.btn_BitfinexImport.Size = new System.Drawing.Size(75, 22);
            this.btn_BitfinexImport.TabIndex = 4;
            this.btn_BitfinexImport.Text = "Import";
            this.btn_BitfinexImport.UseVisualStyleBackColor = true;
            this.btn_BitfinexImport.Click += new System.EventHandler(this.btn_BitfinexImport_Click);
            // 
            // cb_Bitfinex
            // 
            this.cb_Bitfinex.FormattingEnabled = true;
            this.cb_Bitfinex.Location = new System.Drawing.Point(182, 2);
            this.cb_Bitfinex.Name = "cb_Bitfinex";
            this.cb_Bitfinex.Size = new System.Drawing.Size(121, 21);
            this.cb_Bitfinex.TabIndex = 3;
            // 
            // btn_BitfinexOpen
            // 
            this.btn_BitfinexOpen.Location = new System.Drawing.Point(150, 2);
            this.btn_BitfinexOpen.Name = "btn_BitfinexOpen";
            this.btn_BitfinexOpen.Size = new System.Drawing.Size(26, 22);
            this.btn_BitfinexOpen.TabIndex = 2;
            this.btn_BitfinexOpen.Text = "...";
            this.btn_BitfinexOpen.UseVisualStyleBackColor = true;
            this.btn_BitfinexOpen.Click += new System.EventHandler(this.btn_BitfinexOpen_Click);
            // 
            // txt_BitfinexPath
            // 
            this.txt_BitfinexPath.Location = new System.Drawing.Point(50, 3);
            this.txt_BitfinexPath.Name = "txt_BitfinexPath";
            this.txt_BitfinexPath.Size = new System.Drawing.Size(100, 20);
            this.txt_BitfinexPath.TabIndex = 1;
            // 
            // lbl_Bitfinex
            // 
            this.lbl_Bitfinex.AutoSize = true;
            this.lbl_Bitfinex.Location = new System.Drawing.Point(3, 6);
            this.lbl_Bitfinex.Name = "lbl_Bitfinex";
            this.lbl_Bitfinex.Size = new System.Drawing.Size(41, 13);
            this.lbl_Bitfinex.TabIndex = 0;
            this.lbl_Bitfinex.Text = "Bitfinex";
            // 
            // tp_Settings
            // 
            this.tp_Settings.Controls.Add(this.lbl_Version);
            this.tp_Settings.Location = new System.Drawing.Point(4, 22);
            this.tp_Settings.Name = "tp_Settings";
            this.tp_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Settings.Size = new System.Drawing.Size(1228, 601);
            this.tp_Settings.TabIndex = 1;
            this.tp_Settings.Text = "Settings";
            this.tp_Settings.UseVisualStyleBackColor = true;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(1150, 585);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(72, 13);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "Version: 0.1.0";
            // 
            // ofd_Profile
            // 
            this.ofd_Profile.DefaultExt = "json";
            this.ofd_Profile.FileName = "Profile";
            this.ofd_Profile.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Enterprise\\Common7\\IDE\\";
            // 
            // btn_RefreshPrices
            // 
            this.btn_RefreshPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RefreshPrices.Location = new System.Drawing.Point(998, 13);
            this.btn_RefreshPrices.Name = "btn_RefreshPrices";
            this.btn_RefreshPrices.Size = new System.Drawing.Size(92, 23);
            this.btn_RefreshPrices.TabIndex = 4;
            this.btn_RefreshPrices.Text = "Refresh Prices";
            this.btn_RefreshPrices.UseVisualStyleBackColor = true;
            this.btn_RefreshPrices.Click += new System.EventHandler(this.btn_RefreshPrices_Click);
            // 
            // lbl_TotalHoldings
            // 
            this.lbl_TotalHoldings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalHoldings.AutoSize = true;
            this.lbl_TotalHoldings.Location = new System.Drawing.Point(911, 17);
            this.lbl_TotalHoldings.Name = "lbl_TotalHoldings";
            this.lbl_TotalHoldings.Size = new System.Drawing.Size(81, 13);
            this.lbl_TotalHoldings.TabIndex = 5;
            this.lbl_TotalHoldings.Text = "Total Holdings: ";
            this.lbl_TotalHoldings.SizeChanged += new System.EventHandler(this.lbl_TotalHoldings_SizeChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_TotalHoldings);
            this.Controls.Add(this.btn_RefreshPrices);
            this.Controls.Add(this.tc_Main);
            this.Controls.Add(this.btn_LoadProfile);
            this.Controls.Add(this.btn_CreateProfile);
            this.Controls.Add(this.lbl_Profile);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.Text = "Crypto Account Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.tc_Main.ResumeLayout(false);
            this.tp_Accounts.ResumeLayout(false);
            this.tp_Accounts.PerformLayout();
            this.tc_Transactions.ResumeLayout(false);
            this.tp_Transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Transactions)).EndInit();
            this.tp_Trades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Trades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Accounts)).EndInit();
            this.tp_TotalPortfolio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_CurrencyLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_TotalPortfolio)).EndInit();
            this.tp_Import.ResumeLayout(false);
            this.tp_Import.PerformLayout();
            this.tp_Settings.ResumeLayout(false);
            this.tp_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Profile;
        private System.Windows.Forms.Button btn_CreateProfile;
        private System.Windows.Forms.Button btn_LoadProfile;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tp_Accounts;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.DataGridView dg_Accounts;
        private System.Windows.Forms.TabPage tp_Settings;
        private System.Windows.Forms.TabControl tc_Transactions;
        private System.Windows.Forms.TabPage tp_Transactions;
        private System.Windows.Forms.TabPage tp_Trades;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.DataGridView dg_Balance;
        private System.Windows.Forms.Label lbl_Accounts;
        private System.Windows.Forms.Button btn_CreateTransaction;
        private System.Windows.Forms.Button btn_DeleteTransaction;
        private System.Windows.Forms.Button btn_EditTransaction;
        private System.Windows.Forms.DataGridView dg_Transactions;
        private System.Windows.Forms.Button btn_CreateTrade;
        private System.Windows.Forms.Button btn_DeleteTrade;
        private System.Windows.Forms.Button btn_EditTrade;
        private System.Windows.Forms.DataGridView dg_Trades;
        private System.Windows.Forms.OpenFileDialog ofd_Profile;
        private System.Windows.Forms.TabPage tp_Import;
        private System.Windows.Forms.Button btn_BitfinexImport;
        private System.Windows.Forms.ComboBox cb_Bitfinex;
        private System.Windows.Forms.Button btn_BitfinexOpen;
        private System.Windows.Forms.TextBox txt_BitfinexPath;
        private System.Windows.Forms.Label lbl_Bitfinex;
        private System.Windows.Forms.ComboBox cb_CurrencyFilter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_GdaxImport;
        private System.Windows.Forms.ComboBox cb_Gdax;
        private System.Windows.Forms.Button btn_GdaxOpen;
        private System.Windows.Forms.TextBox txt_GdaxPath;
        private System.Windows.Forms.Label lbl_Gdax;
        private System.Windows.Forms.TabPage tp_TotalPortfolio;
        private System.Windows.Forms.DataGridView dg_CurrencyLocation;
        private System.Windows.Forms.DataGridView dg_TotalPortfolio;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Button btn_RefreshPrices;
        private System.Windows.Forms.Label lbl_TotalHoldings;
    }
}

