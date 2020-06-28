using System;
using CafeMana.DTO;
using CafeMana.BLL;
using System.Windows.Forms;

namespace CafeMana.VIEW
{
    public partial class CashForm : Form
    {
        public CashForm()
        {
            InitializeComponent();
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            LoadTotalBill();
        }

        private void LoadTotalBill()
        {
            DataGridView dataGridView = (DataGridView)Tag;
            decimal Bill         = 0;
            decimal TotalBill = 0;
            decimal Discount = 0;

            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                decimal Price = Convert.ToDecimal(row.Cells["ProductPrice"].Value);
                int Quantity  = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                Discount = numericDiscount.Value;
                Bill    += Price * Quantity;
                TotalBill = Bill * ((100 - Discount) / 100); ;
            }
            
            txtBill.Text = Bill.ToString();
            txtTotalBill.Text = TotalBill.ToString();
        }

        private void txtCashGiven_TextChanged(object sender, EventArgs e)
        {
            decimal CashGiven = 0, TotalBill, Bill, Discount, CashReturn;
            try
            {
                 Bill = Convert.ToDecimal(txtBill.Text);
                 Discount = numericDiscount.Value;
                 TotalBill = Bill * ((100 - Discount) / 100);
                
                if (txtCashGiven.Text != "") { CashGiven = Convert.ToDecimal(txtCashGiven.Text); }
                 CashReturn = CashGiven - TotalBill;
                if (txtCashGiven.Text != "") txtCashReturn.Text = CashReturn.ToString();
                else txtCashReturn.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void numericDiscount_ValueChanged(object sender, EventArgs e)
        {
            decimal CashGiven =0, TotalBill, Bill, Discount, CashReturn;
            try
            {
               
                     Bill = Convert.ToDecimal(txtBill.Text);
                     Discount = numericDiscount.Value;
                     TotalBill = Bill * ((100 - Discount) / 100);
                     if (txtCashGiven.Text != "") { CashGiven = Convert.ToDecimal(txtCashGiven.Text); }
                     CashReturn = CashGiven - TotalBill;
                     txtTotalBill.Text = TotalBill.ToString();
                     if (CashReturn>=0) txtCashReturn.Text = CashReturn.ToString();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void ConfirmCheckoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure!", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridView dataGridView = (DataGridView)this.Tag;
                decimal TotalBill  = Convert.ToDecimal(txtBill.Text);
                decimal Discount = numericDiscount.Value;
                decimal CashGiven  = Convert.ToDecimal(txtCashGiven.Text);
                decimal CashReturn = Convert.ToDecimal(txtCashReturn.Text);

                Sale sale = new Sale() { ID = SaleBLL.Instance.RetreiveSaleID(), Total = (TotalBill*(1-Discount/100)), CashGiven = CashGiven, CashReturn = CashReturn, Time = DateTime.Now, SalesManID = 1 };
                SaleBLL.Instance.AddNewSale(sale);
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    SaleItem saleItem        = new SaleItem();
                    saleItem.ID              = SaleItemBLL.Instance.RetreiveSaleItemID();
                    saleItem.ProductName     = Convert.ToString(row.Cells["ProductName"].Value);
                    saleItem.ProductPrice    = Convert.ToDecimal(row.Cells["ProductPrice"].Value);
                    saleItem.ProductQuantity = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                    saleItem.ProductTotal    = Convert.ToDecimal(row.Cells["ProductTotal"].Value);
                    saleItem.SaleID          = sale.ID;

                    SaleItemBLL.Instance.AddNewSaleItem(saleItem);
                    this.Close();
                }                
            }
           

        }

        
    }
}
