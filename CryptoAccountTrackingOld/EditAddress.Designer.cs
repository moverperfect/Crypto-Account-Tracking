namespace CryptoAccountTracking
{
    partial class EditAddress
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
            this.lbl_AddressName = new System.Windows.Forms.Label();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.txt_AddressName = new System.Windows.Forms.TextBox();
            this.dg_Currencies = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Currencies)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddressName
            // 
            this.lbl_AddressName.AutoSize = true;
            this.lbl_AddressName.Location = new System.Drawing.Point(13, 16);
            this.lbl_AddressName.Name = "lbl_AddressName";
            this.lbl_AddressName.Size = new System.Drawing.Size(76, 13);
            this.lbl_AddressName.TabIndex = 0;
            this.lbl_AddressName.Text = "AddressName:";
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.AutoSize = true;
            this.lbl_Currency.Location = new System.Drawing.Point(13, 65);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(52, 13);
            this.lbl_Currency.TabIndex = 1;
            this.lbl_Currency.Text = "Currency:";
            // 
            // txt_AddressName
            // 
            this.txt_AddressName.Location = new System.Drawing.Point(95, 13);
            this.txt_AddressName.Name = "txt_AddressName";
            this.txt_AddressName.Size = new System.Drawing.Size(526, 20);
            this.txt_AddressName.TabIndex = 2;
            // 
            // dg_Currencies
            // 
            this.dg_Currencies.AllowUserToDeleteRows = false;
            this.dg_Currencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Currencies.Location = new System.Drawing.Point(95, 65);
            this.dg_Currencies.MultiSelect = false;
            this.dg_Currencies.Name = "dg_Currencies";
            this.dg_Currencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Currencies.Size = new System.Drawing.Size(526, 337);
            this.dg_Currencies.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(546, 408);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(465, 408);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(13, 42);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(48, 13);
            this.lbl_Address.TabIndex = 6;
            this.lbl_Address.Text = "Address:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(95, 39);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(526, 20);
            this.txt_Address.TabIndex = 7;
            // 
            // EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 443);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dg_Currencies);
            this.Controls.Add(this.txt_AddressName);
            this.Controls.Add(this.lbl_Currency);
            this.Controls.Add(this.lbl_AddressName);
            this.Name = "EditAddress";
            this.Text = "EditAddress";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Currencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddressName;
        private System.Windows.Forms.Label lbl_Currency;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.TextBox txt_AddressName;
        internal System.Windows.Forms.DataGridView dg_Currencies;
        private System.Windows.Forms.Label lbl_Address;
        internal System.Windows.Forms.TextBox txt_Address;
    }
}