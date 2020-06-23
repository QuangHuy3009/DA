using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMana.DTO;
using CafeMana.BLL;

namespace CafeMana.VIEW
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadSale();
        }

        private void LoadSale()
        {
            List<Sale> SalesList = Data.Instance.SalesList;
            List<User> UsersList = Data.Instance.UsersList;
            SalesGridView.Rows.Clear();
            foreach (Sale sale in SalesList)
            {
                foreach (User user in UsersList)
                {
                    if (user.ID == sale.SalesManID) { SalesGridView.Rows.Add(sale.ID, sale.Time, user.Name, sale.Total, "View Product"); break; }
                }

            }
        }

        #region Event

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct _AddProduct = new AddProduct();
            _AddProduct.ShowDialog();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory _AddCategory = new AddCategory();
            _AddCategory.ShowDialog();
        }

        private void buttonAddAcc_Click(object sender, EventArgs e)
        {
            AddAccount _AddAccount = new AddAccount();
            _AddAccount.ShowDialog();
        }

        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SalesGridView.Columns[e.ColumnIndex].Name == "ProductsColumn")
                {
                    int SaleID = Convert.ToInt32(SalesGridView.Rows[e.RowIndex].Cells["SaleIDColumn"].Value);

                    SaleItems saleItems = new SaleItems();
                    saleItems.Tag = SaleID;
                    saleItems.ShowDialog();
                }
            }
        }

        private void buttonThongke_Click(object sender, EventArgs e)
        {
            DateTime Time = dateTimePicker1.Value;
            List<Sale> SalesList = Data.Instance.SalesList;
            List<User> UsersList = Data.Instance.UsersList;
            SalesGridView.Rows.Clear();
            foreach (Sale sale in SalesList)
            {
                if (sale.Time.Day == Time.Day && sale.Time.Month == Time.Month && sale.Time.Year == Time.Year)
                {
                    foreach (User user in UsersList)
                    {
                        if (user.ID == sale.SalesManID) { SalesGridView.Rows.Add(sale.ID, sale.Time, user.Name, sale.Total, "View Product"); break; }
                    }
                }

            }
        }

        #endregion


    }
}
