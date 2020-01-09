namespace CryptoAccountTracking
{
    internal partial class EditTransaction
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
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Fee = new System.Windows.Forms.Label();
            this.lbl_TransactionHash = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.cb_From = new System.Windows.Forms.ComboBox();
            this.cb_To = new System.Windows.Forms.ComboBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Fee = new System.Windows.Forms.TextBox();
            this.txt_Hash = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(12, 9);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(33, 13);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date:";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(12, 36);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(36, 13);
            this.lbl_From.TabIndex = 1;
            this.lbl_From.Text = "From: ";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(12, 63);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(26, 13);
            this.lbl_To.TabIndex = 2;
            this.lbl_To.Text = "To: ";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(12, 90);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(49, 13);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount: ";
            // 
            // lbl_Fee
            // 
            this.lbl_Fee.AutoSize = true;
            this.lbl_Fee.Location = new System.Drawing.Point(12, 116);
            this.lbl_Fee.Name = "lbl_Fee";
            this.lbl_Fee.Size = new System.Drawing.Size(28, 13);
            this.lbl_Fee.TabIndex = 4;
            this.lbl_Fee.Text = "Fee:";
            // 
            // lbl_TransactionHash
            // 
            this.lbl_TransactionHash.AutoSize = true;
            this.lbl_TransactionHash.Location = new System.Drawing.Point(12, 146);
            this.lbl_TransactionHash.Name = "lbl_TransactionHash";
            this.lbl_TransactionHash.Size = new System.Drawing.Size(94, 13);
            this.lbl_TransactionHash.TabIndex = 5;
            this.lbl_TransactionHash.Text = "Transaction Hash:";
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(112, 7);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(322, 20);
            this.dtp_Date.TabIndex = 6;
            // 
            // cb_From
            // 
            this.cb_From.FormattingEnabled = true;
            this.cb_From.Location = new System.Drawing.Point(112, 33);
            this.cb_From.Name = "cb_From";
            this.cb_From.Size = new System.Drawing.Size(322, 21);
            this.cb_From.TabIndex = 7;
            // 
            // cb_To
            // 
            this.cb_To.FormattingEnabled = true;
            this.cb_To.Location = new System.Drawing.Point(112, 60);
            this.cb_To.Name = "cb_To";
            this.cb_To.Size = new System.Drawing.Size(322, 21);
            this.cb_To.TabIndex = 8;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(112, 87);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(322, 20);
            this.txt_Amount.TabIndex = 9;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumbersOnly_KeyPress);
            // 
            // txt_Fee
            // 
            this.txt_Fee.Location = new System.Drawing.Point(112, 113);
            this.txt_Fee.Name = "txt_Fee";
            this.txt_Fee.Size = new System.Drawing.Size(322, 20);
            this.txt_Fee.TabIndex = 10;
            this.txt_Fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumbersOnly_KeyPress);
            // 
            // txt_Hash
            // 
            this.txt_Hash.Location = new System.Drawing.Point(112, 139);
            this.txt_Hash.Name = "txt_Hash";
            this.txt_Hash.Size = new System.Drawing.Size(322, 20);
            this.txt_Hash.TabIndex = 11;
            this.txt_Hash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumbersOnly_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(357, 165);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(276, 165);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // EditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 196);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Hash);
            this.Controls.Add(this.txt_Fee);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.cb_To);
            this.Controls.Add(this.cb_From);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lbl_TransactionHash);
            this.Controls.Add(this.lbl_Fee);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.lbl_Date);
            this.Name = "EditTransaction";
            this.Text = "EditTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Fee;
        private System.Windows.Forms.Label lbl_TransactionHash;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.ComboBox cb_From;
        private System.Windows.Forms.ComboBox cb_To;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Fee;
        private System.Windows.Forms.TextBox txt_Hash;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}