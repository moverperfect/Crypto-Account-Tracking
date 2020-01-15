namespace CryptoAccountTracking.Forms
{
    internal partial class EditAccount
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Notes = new System.Windows.Forms.RichTextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.cb_CustomAddress = new System.Windows.Forms.CheckBox();
            this.txt_CurrencyCode = new System.Windows.Forms.TextBox();
            this.lbl_CurrencyCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(192, 371);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(273, 372);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(15, 100);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(336, 266);
            this.txt_Notes.TabIndex = 9;
            this.txt_Notes.Text = "";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(135, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 8;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Location = new System.Drawing.Point(12, 84);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(38, 13);
            this.lbl_Notes.TabIndex = 7;
            this.lbl_Notes.Text = "Notes:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 12);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 13);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Name: ";
            // 
            // txt_Address
            // 
            this.txt_Address.Enabled = false;
            this.txt_Address.Location = new System.Drawing.Point(135, 35);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 20);
            this.txt_Address.TabIndex = 13;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(12, 38);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(51, 13);
            this.lbl_Address.TabIndex = 12;
            this.lbl_Address.Text = "Address: ";
            // 
            // cb_CustomAddress
            // 
            this.cb_CustomAddress.AutoSize = true;
            this.cb_CustomAddress.Location = new System.Drawing.Point(241, 37);
            this.cb_CustomAddress.Name = "cb_CustomAddress";
            this.cb_CustomAddress.Size = new System.Drawing.Size(67, 17);
            this.cb_CustomAddress.TabIndex = 14;
            this.cb_CustomAddress.Text = "Custom?";
            this.cb_CustomAddress.UseVisualStyleBackColor = true;
            this.cb_CustomAddress.CheckedChanged += new System.EventHandler(this.cb_CustomAddress_CheckedChanged);
            // 
            // txt_CurrencyCode
            // 
            this.txt_CurrencyCode.Location = new System.Drawing.Point(135, 61);
            this.txt_CurrencyCode.Name = "txt_CurrencyCode";
            this.txt_CurrencyCode.Size = new System.Drawing.Size(100, 20);
            this.txt_CurrencyCode.TabIndex = 16;
            // 
            // lbl_CurrencyCode
            // 
            this.lbl_CurrencyCode.AutoSize = true;
            this.lbl_CurrencyCode.Location = new System.Drawing.Point(12, 64);
            this.lbl_CurrencyCode.Name = "lbl_CurrencyCode";
            this.lbl_CurrencyCode.Size = new System.Drawing.Size(117, 13);
            this.lbl_CurrencyCode.TabIndex = 15;
            this.lbl_CurrencyCode.Text = "Default Currency Code:";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 410);
            this.Controls.Add(this.txt_CurrencyCode);
            this.Controls.Add(this.lbl_CurrencyCode);
            this.Controls.Add(this.cb_CustomAddress);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_Name);
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        internal System.Windows.Forms.RichTextBox txt_Notes;
        internal System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.Label lbl_Name;
        internal System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.CheckBox cb_CustomAddress;
        internal System.Windows.Forms.TextBox txt_CurrencyCode;
        private System.Windows.Forms.Label lbl_CurrencyCode;
    }
}