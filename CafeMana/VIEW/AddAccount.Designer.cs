namespace CafeMana.VIEW
{
    partial class AddAccount
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.txbConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBoxRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Window;
            this.panel12.Controls.Add(this.ButtonAdd);
            this.panel12.Controls.Add(this.txbConfirm);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.txbPassword);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.txbEmail);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.cbBoxRole);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.txbUserName);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Location = new System.Drawing.Point(16, 15);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(365, 356);
            this.panel12.TabIndex = 13;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAdd.Location = new System.Drawing.Point(115, 284);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(235, 28);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "Add Account";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // txbConfirm
            // 
            this.txbConfirm.Location = new System.Drawing.Point(115, 214);
            this.txbConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.PasswordChar = '*';
            this.txbConfirm.Size = new System.Drawing.Size(235, 22);
            this.txbConfirm.TabIndex = 13;
            this.txbConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirm";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(115, 167);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(235, 22);
            this.txbPassword.TabIndex = 11;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(115, 121);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(235, 22);
            this.txbEmail.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 121);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Email";
            // 
            // cbBoxRole
            // 
            this.cbBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRole.FormattingEnabled = true;
            this.cbBoxRole.Items.AddRange(new object[] {
            "Admin",
            "SaleMans"});
            this.cbBoxRole.Location = new System.Drawing.Point(115, 73);
            this.cbBoxRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbBoxRole.Name = "cbBoxRole";
            this.cbBoxRole.Size = new System.Drawing.Size(235, 24);
            this.cbBoxRole.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Role";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(115, 26);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(235, 22);
            this.txbUserName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "UserName";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 384);
            this.Controls.Add(this.panel12);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAccount";
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox txbConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbBoxRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label12;
    }
}