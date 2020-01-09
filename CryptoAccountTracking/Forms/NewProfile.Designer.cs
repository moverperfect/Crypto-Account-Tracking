namespace CryptoAccountTracking.Forms
{
    partial class NewProfile
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
            this.txt_ProfileName = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProfileName
            // 
            this.lbl_ProfileName.AutoSize = true;
            this.lbl_ProfileName.Location = new System.Drawing.Point(13, 13);
            this.lbl_ProfileName.Name = "lbl_ProfileName";
            this.lbl_ProfileName.Size = new System.Drawing.Size(73, 13);
            this.lbl_ProfileName.TabIndex = 0;
            this.lbl_ProfileName.Text = "Profile Name: ";
            // 
            // txt_ProfileName
            // 
            this.txt_ProfileName.Location = new System.Drawing.Point(92, 10);
            this.txt_ProfileName.Name = "txt_ProfileName";
            this.txt_ProfileName.Size = new System.Drawing.Size(163, 20);
            this.txt_ProfileName.TabIndex = 1;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(179, 37);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // NewProfile
            // 
            this.AcceptButton = this.btn_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 72);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_ProfileName);
            this.Controls.Add(this.lbl_ProfileName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProfileName;
        private System.Windows.Forms.TextBox txt_ProfileName;
        private System.Windows.Forms.Button btn_Create;
    }
}