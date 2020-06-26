namespace CafeMana.VIEW
{
    partial class CashForm
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
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmCheckoutButton = new System.Windows.Forms.Button();
            this.txtCashReturn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCashGiven = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(136, 59);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(175, 22);
            this.txtDiscount.TabIndex = 17;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Discount";
            // 
            // ConfirmCheckoutButton
            // 
            this.ConfirmCheckoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmCheckoutButton.Location = new System.Drawing.Point(76, 229);
            this.ConfirmCheckoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmCheckoutButton.Name = "ConfirmCheckoutButton";
            this.ConfirmCheckoutButton.Size = new System.Drawing.Size(192, 28);
            this.ConfirmCheckoutButton.TabIndex = 15;
            this.ConfirmCheckoutButton.Text = "Confirm Checkout";
            this.ConfirmCheckoutButton.UseVisualStyleBackColor = true;
            this.ConfirmCheckoutButton.Click += new System.EventHandler(this.ConfirmCheckoutButton_Click);
            // 
            // txtCashReturn
            // 
            this.txtCashReturn.Location = new System.Drawing.Point(136, 124);
            this.txtCashReturn.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashReturn.Name = "txtCashReturn";
            this.txtCashReturn.ReadOnly = true;
            this.txtCashReturn.Size = new System.Drawing.Size(175, 22);
            this.txtCashReturn.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cash Return";
            // 
            // txtCashGiven
            // 
            this.txtCashGiven.Location = new System.Drawing.Point(136, 89);
            this.txtCashGiven.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashGiven.Name = "txtCashGiven";
            this.txtCashGiven.Size = new System.Drawing.Size(175, 22);
            this.txtCashGiven.TabIndex = 12;
            this.txtCashGiven.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cash Given";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(136, 27);
            this.txtTotalBill.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(175, 22);
            this.txtTotalBill.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Bill";
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 286);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmCheckoutButton);
            this.Controls.Add(this.txtCashReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCashGiven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashForm";
            this.Text = "CashForm";
            this.Load += new System.EventHandler(this.CashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmCheckoutButton;
        public System.Windows.Forms.TextBox txtCashReturn;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCashGiven;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label1;
    }
}