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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCashReturn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCashGiven = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.buttonConfirmCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Discount (%)";
            // 
            // txtCashReturn
            // 
            this.txtCashReturn.Location = new System.Drawing.Point(102, 132);
            this.txtCashReturn.Name = "txtCashReturn";
            this.txtCashReturn.ReadOnly = true;
            this.txtCashReturn.Size = new System.Drawing.Size(132, 20);
            this.txtCashReturn.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cash Return";
            // 
            // txtCashGiven
            // 
            this.txtCashGiven.Location = new System.Drawing.Point(102, 103);
            this.txtCashGiven.Name = "txtCashGiven";
            this.txtCashGiven.Size = new System.Drawing.Size(132, 20);
            this.txtCashGiven.TabIndex = 12;
            this.txtCashGiven.TextChanged += new System.EventHandler(this.txtCashGiven_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cash Given";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(102, 22);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(132, 20);
            this.txtBill.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bill";
            // 
            // numericDiscount
            // 
            this.numericDiscount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDiscount.Location = new System.Drawing.Point(102, 48);
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(132, 20);
            this.numericDiscount.TabIndex = 17;
            this.numericDiscount.ValueChanged += new System.EventHandler(this.numericDiscount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Bill";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(102, 79);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(132, 20);
            this.txtTotalBill.TabIndex = 19;
            // 
            // buttonConfirmCheckout
            // 
            this.buttonConfirmCheckout.Location = new System.Drawing.Point(112, 180);
            this.buttonConfirmCheckout.Name = "buttonConfirmCheckout";
            this.buttonConfirmCheckout.Size = new System.Drawing.Size(122, 23);
            this.buttonConfirmCheckout.TabIndex = 20;
            this.buttonConfirmCheckout.Text = "Confirm Checkout";
            this.buttonConfirmCheckout.UseVisualStyleBackColor = true;
            this.buttonConfirmCheckout.Click += new System.EventHandler(this.buttonConfirmCheckout_Click);
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 232);
            this.Controls.Add(this.buttonConfirmCheckout);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCashReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCashGiven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label1);
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashForm";
            this.Load += new System.EventHandler(this.CashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCashReturn;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCashGiven;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Button buttonConfirmCheckout;
    }
}