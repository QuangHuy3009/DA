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
            DataGridView dataGridView = (DataGridView)this.Tag;
            decimal TotalBill         = 0;

            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                decimal Price = Convert.ToDecimal(row.Cells["ProductPrice"].Value);
                int Quantity  = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                TotalBill    += Price * Quantity;
            }

            txtTotalBill.Text = TotalBill.ToString();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TotalBill  = Convert.ToDecimal(txtTotalBill.Text);
                decimal Discount   = Convert.ToDecimal(txtDiscount.Text);
                decimal CashGiven  = Convert.ToDecimal(txtCashGiven.Text);
                decimal CashReturn = CashGiven - (TotalBill - Discount);
                txtCashReturn.Text = CashReturn.ToString(); 
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
                decimal TotalBill  = Convert.ToDecimal(txtTotalBill.Text);
                decimal Discount   = Convert.ToDecimal(txtDiscount.Text);
                decimal CashGiven  = Convert.ToDecimal(txtCashGiven.Text);
                decimal CashReturn = Convert.ToDecimal(txtCashReturn.Text);

                Sale sale = new Sale() { ID = SaleBLL.Instance.RetreiveSaleID(), Total = (TotalBill - Discount), CashGiven = CashGiven, CashReturn = CashReturn, Time = DateTime.Now, SalesManID = 1 };
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
                }
            }

        }       

       
    }
}
