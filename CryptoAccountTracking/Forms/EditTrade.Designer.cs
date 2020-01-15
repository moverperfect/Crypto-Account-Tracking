namespace CryptoAccountTracking.Forms
{
    partial class EditTrade
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
            this.txt_FeeCurrency = new System.Windows.Forms.TextBox();
            this.lbl_FeeCurrency = new System.Windows.Forms.Label();
            this.txt_FromCurrency = new System.Windows.Forms.TextBox();
            this.lbl_FromCurrency = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Hash = new System.Windows.Forms.TextBox();
            this.txt_Fee = new System.Windows.Forms.TextBox();
            this.txt_FromAmount = new System.Windows.Forms.TextBox();
            this.cb_To = new System.Windows.Forms.ComboBox();
            this.cb_From = new System.Windows.Forms.ComboBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_TransactionHash = new System.Windows.Forms.Label();
            this.lbl_Fee = new System.Windows.Forms.Label();
            this.lbl_FromAmount = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.txt_ToCurrency = new System.Windows.Forms.TextBox();
            this.lbl_ToCurrency = new System.Windows.Forms.Label();
            this.txt_ToAmount = new System.Windows.Forms.TextBox();
            this.lbl_ToAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_FeeCurrency
            // 
            this.txt_FeeCurrency.Location = new System.Drawing.Point(112, 217);
            this.txt_FeeCurrency.Name = "txt_FeeCurrency";
            this.txt_FeeCurrency.Size = new System.Drawing.Size(322, 20);
            this.txt_FeeCurrency.TabIndex = 9;
            // 
            // lbl_FeeCurrency
            // 
            this.lbl_FeeCurrency.AutoSize = true;
            this.lbl_FeeCurrency.Location = new System.Drawing.Point(12, 220);
            this.lbl_FeeCurrency.Name = "lbl_FeeCurrency";
            this.lbl_FeeCurrency.Size = new System.Drawing.Size(73, 13);
            this.lbl_FeeCurrency.TabIndex = 48;
            this.lbl_FeeCurrency.Text = "Fee Currency:";
            // 
            // txt_FromCurrency
            // 
            this.txt_FromCurrency.Location = new System.Drawing.Point(112, 113);
            this.txt_FromCurrency.Name = "txt_FromCurrency";
            this.txt_FromCurrency.Size = new System.Drawing.Size(322, 20);
            this.txt_FromCurrency.TabIndex = 5;
            // 
            // lbl_FromCurrency
            // 
            this.lbl_FromCurrency.AutoSize = true;
            this.lbl_FromCurrency.Location = new System.Drawing.Point(12, 116);
            this.lbl_FromCurrency.Name = "lbl_FromCurrency";
            this.lbl_FromCurrency.Size = new System.Drawing.Size(78, 13);
            this.lbl_FromCurrency.TabIndex = 46;
            this.lbl_FromCurrency.Text = "From Currency:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(278, 269);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(359, 269);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Hash
            // 
            this.txt_Hash.Location = new System.Drawing.Point(112, 243);
            this.txt_Hash.Name = "txt_Hash";
            this.txt_Hash.Size = new System.Drawing.Size(322, 20);
            this.txt_Hash.TabIndex = 10;
            // 
            // txt_Fee
            // 
            this.txt_Fee.Location = new System.Drawing.Point(112, 191);
            this.txt_Fee.Name = "txt_Fee";
            this.txt_Fee.Size = new System.Drawing.Size(322, 20);
            this.txt_Fee.TabIndex = 8;
            // 
            // txt_FromAmount
            // 
            this.txt_FromAmount.Location = new System.Drawing.Point(112, 87);
            this.txt_FromAmount.Name = "txt_FromAmount";
            this.txt_FromAmount.Size = new System.Drawing.Size(322, 20);
            this.txt_FromAmount.TabIndex = 4;
            // 
            // cb_To
            // 
            this.cb_To.FormattingEnabled = true;
            this.cb_To.Location = new System.Drawing.Point(112, 60);
            this.cb_To.Name = "cb_To";
            this.cb_To.Size = new System.Drawing.Size(322, 21);
            this.cb_To.TabIndex = 3;
            // 
            // cb_From
            // 
            this.cb_From.FormattingEnabled = true;
            this.cb_From.Location = new System.Drawing.Point(112, 33);
            this.cb_From.Name = "cb_From";
            this.cb_From.Size = new System.Drawing.Size(322, 21);
            this.cb_From.TabIndex = 2;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(112, 7);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(322, 20);
            this.dtp_Date.TabIndex = 1;
            // 
            // lbl_TransactionHash
            // 
            this.lbl_TransactionHash.AutoSize = true;
            this.lbl_TransactionHash.Location = new System.Drawing.Point(12, 246);
            this.lbl_TransactionHash.Name = "lbl_TransactionHash";
            this.lbl_TransactionHash.Size = new System.Drawing.Size(94, 13);
            this.lbl_TransactionHash.TabIndex = 37;
            this.lbl_TransactionHash.Text = "Transaction Hash:";
            // 
            // lbl_Fee
            // 
            this.lbl_Fee.AutoSize = true;
            this.lbl_Fee.Location = new System.Drawing.Point(12, 194);
            this.lbl_Fee.Name = "lbl_Fee";
            this.lbl_Fee.Size = new System.Drawing.Size(28, 13);
            this.lbl_Fee.TabIndex = 36;
            this.lbl_Fee.Text = "Fee:";
            // 
            // lbl_FromAmount
            // 
            this.lbl_FromAmount.AutoSize = true;
            this.lbl_FromAmount.Location = new System.Drawing.Point(12, 90);
            this.lbl_FromAmount.Name = "lbl_FromAmount";
            this.lbl_FromAmount.Size = new System.Drawing.Size(75, 13);
            this.lbl_FromAmount.TabIndex = 35;
            this.lbl_FromAmount.Text = "From Amount: ";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(12, 63);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(26, 13);
            this.lbl_To.TabIndex = 34;
            this.lbl_To.Text = "To: ";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(12, 36);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(36, 13);
            this.lbl_From.TabIndex = 33;
            this.lbl_From.Text = "From: ";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(12, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(33, 13);
            this.lbl_Date.TabIndex = 32;
            this.lbl_Date.Text = "Date:";
            // 
            // txt_ToCurrency
            // 
            this.txt_ToCurrency.Location = new System.Drawing.Point(112, 165);
            this.txt_ToCurrency.Name = "txt_ToCurrency";
            this.txt_ToCurrency.Size = new System.Drawing.Size(322, 20);
            this.txt_ToCurrency.TabIndex = 7;
            // 
            // lbl_ToCurrency
            // 
            this.lbl_ToCurrency.AutoSize = true;
            this.lbl_ToCurrency.Location = new System.Drawing.Point(12, 168);
            this.lbl_ToCurrency.Name = "lbl_ToCurrency";
            this.lbl_ToCurrency.Size = new System.Drawing.Size(68, 13);
            this.lbl_ToCurrency.TabIndex = 52;
            this.lbl_ToCurrency.Text = "To Currency:";
            // 
            // txt_ToAmount
            // 
            this.txt_ToAmount.Location = new System.Drawing.Point(112, 139);
            this.txt_ToAmount.Name = "txt_ToAmount";
            this.txt_ToAmount.Size = new System.Drawing.Size(322, 20);
            this.txt_ToAmount.TabIndex = 6;
            // 
            // lbl_ToAmount
            // 
            this.lbl_ToAmount.AutoSize = true;
            this.lbl_ToAmount.Location = new System.Drawing.Point(12, 142);
            this.lbl_ToAmount.Name = "lbl_ToAmount";
            this.lbl_ToAmount.Size = new System.Drawing.Size(65, 13);
            this.lbl_ToAmount.TabIndex = 50;
            this.lbl_ToAmount.Text = "To Amount: ";
            // 
            // EditTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 302);
            this.Controls.Add(this.txt_ToCurrency);
            this.Controls.Add(this.lbl_ToCurrency);
            this.Controls.Add(this.txt_ToAmount);
            this.Controls.Add(this.lbl_ToAmount);
            this.Controls.Add(this.txt_FeeCurrency);
            this.Controls.Add(this.lbl_FeeCurrency);
            this.Controls.Add(this.txt_FromCurrency);
            this.Controls.Add(this.lbl_FromCurrency);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Hash);
            this.Controls.Add(this.txt_Fee);
            this.Controls.Add(this.txt_FromAmount);
            this.Controls.Add(this.cb_To);
            this.Controls.Add(this.cb_From);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_TransactionHash);
            this.Controls.Add(this.lbl_Fee);
            this.Controls.Add(this.lbl_FromAmount);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.lbl_Date);
            this.Name = "EditTrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditTrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FeeCurrency;
        private System.Windows.Forms.Label lbl_FeeCurrency;
        private System.Windows.Forms.TextBox txt_FromCurrency;
        private System.Windows.Forms.Label lbl_FromCurrency;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Hash;
        private System.Windows.Forms.TextBox txt_Fee;
        private System.Windows.Forms.TextBox txt_FromAmount;
        private System.Windows.Forms.ComboBox cb_To;
        private System.Windows.Forms.ComboBox cb_From;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_TransactionHash;
        private System.Windows.Forms.Label lbl_Fee;
        private System.Windows.Forms.Label lbl_FromAmount;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txt_ToCurrency;
        private System.Windows.Forms.Label lbl_ToCurrency;
        private System.Windows.Forms.TextBox txt_ToAmount;
        private System.Windows.Forms.Label lbl_ToAmount;
    }
}