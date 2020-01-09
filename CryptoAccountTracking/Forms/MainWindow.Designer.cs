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
            this.btn_NewProfile = new System.Windows.Forms.Button();
            this.btn_LoadProfile = new System.Windows.Forms.Button();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tp_Accounts = new System.Windows.Forms.TabPage();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_Accounts = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tp_Settings = new System.Windows.Forms.TabPage();
            this.tc_Main.SuspendLayout();
            this.tp_Accounts.SuspendLayout();
            this.tc_Transactions.SuspendLayout();
            this.tp_Transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Transactions)).BeginInit();
            this.tp_Trades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Trades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // btn_NewProfile
            // 
            this.btn_NewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewProfile.Location = new System.Drawing.Point(1096, 13);
            this.btn_NewProfile.Name = "btn_NewProfile";
            this.btn_NewProfile.Size = new System.Drawing.Size(75, 23);
            this.btn_NewProfile.TabIndex = 1;
            this.btn_NewProfile.Text = "New Profile";
            this.btn_NewProfile.UseVisualStyleBackColor = true;
            this.btn_NewProfile.Click += new System.EventHandler(this.btn_NewProfile_Click);
            // 
            // btn_LoadProfile
            // 
            this.btn_LoadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadProfile.Enabled = false;
            this.btn_LoadProfile.Location = new System.Drawing.Point(1177, 12);
            this.btn_LoadProfile.Name = "btn_LoadProfile";
            this.btn_LoadProfile.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadProfile.TabIndex = 2;
            this.btn_LoadProfile.Text = "Load Profile";
            this.btn_LoadProfile.UseVisualStyleBackColor = true;
            // 
            // tc_Main
            // 
            this.tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_Main.Controls.Add(this.tp_Accounts);
            this.tc_Main.Controls.Add(this.tp_Settings);
            this.tc_Main.Location = new System.Drawing.Point(16, 42);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(1236, 627);
            this.tc_Main.TabIndex = 3;
            // 
            // tp_Accounts
            // 
            this.tp_Accounts.Controls.Add(this.tc_Transactions);
            this.tp_Accounts.Controls.Add(this.lbl_Balance);
            this.tp_Accounts.Controls.Add(this.dataGridView2);
            this.tp_Accounts.Controls.Add(this.lbl_Accounts);
            this.tp_Accounts.Controls.Add(this.button3);
            this.tp_Accounts.Controls.Add(this.button2);
            this.tp_Accounts.Controls.Add(this.button1);
            this.tp_Accounts.Controls.Add(this.dataGridView1);
            this.tp_Accounts.Location = new System.Drawing.Point(4, 22);
            this.tp_Accounts.Name = "tp_Accounts";
            this.tp_Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Accounts.Size = new System.Drawing.Size(1228, 601);
            this.tp_Accounts.TabIndex = 0;
            this.tp_Accounts.Text = "Accounts";
            this.tp_Accounts.UseVisualStyleBackColor = true;
            // 
            // tc_Transactions
            // 
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
            this.dg_Transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Transactions.Location = new System.Drawing.Point(6, 6);
            this.dg_Transactions.Name = "dg_Transactions";
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
            this.dg_Trades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Trades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Trades.Location = new System.Drawing.Point(6, 6);
            this.dg_Trades.Name = "dg_Trades";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(621, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(601, 230);
            this.dataGridView2.TabIndex = 5;
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(339, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Account";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(436, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(527, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // tp_Settings
            // 
            this.tp_Settings.Location = new System.Drawing.Point(4, 22);
            this.tp_Settings.Name = "tp_Settings";
            this.tp_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Settings.Size = new System.Drawing.Size(1228, 601);
            this.tp_Settings.TabIndex = 1;
            this.tp_Settings.Text = "Settings";
            this.tp_Settings.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tc_Main);
            this.Controls.Add(this.btn_LoadProfile);
            this.Controls.Add(this.btn_NewProfile);
            this.Controls.Add(this.lbl_Profile);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.Text = "Crypto Account Tracking";
            this.tc_Main.ResumeLayout(false);
            this.tp_Accounts.ResumeLayout(false);
            this.tp_Accounts.PerformLayout();
            this.tc_Transactions.ResumeLayout(false);
            this.tp_Transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Transactions)).EndInit();
            this.tp_Trades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Trades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Profile;
        private System.Windows.Forms.Button btn_NewProfile;
        private System.Windows.Forms.Button btn_LoadProfile;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tp_Accounts;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tp_Settings;
        private System.Windows.Forms.TabControl tc_Transactions;
        private System.Windows.Forms.TabPage tp_Transactions;
        private System.Windows.Forms.TabPage tp_Trades;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_Accounts;
        private System.Windows.Forms.Button btn_CreateTransaction;
        private System.Windows.Forms.Button btn_DeleteTransaction;
        private System.Windows.Forms.Button btn_EditTransaction;
        private System.Windows.Forms.DataGridView dg_Transactions;
        private System.Windows.Forms.Button btn_CreateTrade;
        private System.Windows.Forms.Button btn_DeleteTrade;
        private System.Windows.Forms.Button btn_EditTrade;
        private System.Windows.Forms.DataGridView dg_Trades;
    }
}

