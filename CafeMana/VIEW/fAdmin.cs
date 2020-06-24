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
using System.IO;

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
            LoadUser();
            LoadCategories();
            LoadProducts();
        }

        #region Load

        private void LoadUser()
        {
            List<User> UsersList = Data.Instance.UsersList;
            UsersGridView.Rows.Clear();
            foreach (User user in UsersList)
            {
                UsersGridView.Rows.Add(user.ID, user.Name, user.Role);
            }
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
                    if (user.ID == sale.SalesManID) { SalesGridView.Rows.Add(sale.ID, sale.Time, user.Name, sale.Total,null); break; }
                }

            }
        }

        private void LoadCategories()
        {
            List<Category> CategoriesList = Data.Instance.CategoriesList;
            ProductCategoryComboBox.DataSource = CategoriesList;
            ProductCategoryComboBox.DisplayMember = "Name";
        }

        private void LoadProducts()
        {
            ProductsGridView.Rows.Clear();
            List<Product>  ProductsList = Data.Instance.ProductsList;
            List<Category> CategoriesList = Data.Instance.CategoriesList;
            foreach (Product product in ProductsList)
            {
                foreach (Category category in CategoriesList)
                {
                    if (category.ID == product.CatagoryID){ ProductsGridView.Rows.Add(product.ID, product.Name, product.Price,category.Name,product.Description,product.Image); break;}
                }
                
            }
        }

        #endregion

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

        private void buttonFindProduct_Click(object sender, EventArgs e)
        {
            ProductsGridView.Rows.Clear();
            List<Product> ProductsList = Data.Instance.ProductsList;
            int IDCategory             = ((Category)ProductCategoryComboBox.SelectedValue).ID;
            string CategoryName        = ((Category)ProductCategoryComboBox.SelectedValue).Name;
            string Txt                 = txbFindProduct.Text;
            if (Txt == "")
            {
                foreach (Product product in ProductsList)                
                     if (product.CatagoryID == IDCategory)
                         ProductsGridView.Rows.Add(product.ID, product.Name, product.Price, CategoryName, product.Description, product.Image);
                
            }
            else
            {
                foreach (Product product in ProductsList)
                {
                    if (product.CatagoryID == IDCategory)                   
                        if(product.Name.Contains(Txt)|| product.Price.ToString().Contains(Txt) || product.Description.Contains(Txt))
                           ProductsGridView.Rows.Add(product.ID, product.Name, product.Price, CategoryName, product.Description, product.Image);
                }
            }
        }
     

        #endregion

        private void SalesGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // SalesGridView.Rows[e.RowIndex].Cells[4].Value = Image.FromFile(@"C:\Users\HP\Desktop\kinhlup.jpg");
        }

        private void SalesGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           // SalesGridView.Rows[e.RowIndex].Cells[4].Value = Image.FromFile(@"C:\Users\HP\Desktop\kinhlup.jpg");
        }

        private void SalesGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 4)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    string path = Application.StartupPath;
                    path = path.Substring(0, path.IndexOf("bin") - 1);
                    path += "\\Image\\kinhlup.jpg";
                    Image SomeImage = Image.FromFile(path);
                    var w = SomeImage.Width;
                    var h = SomeImage.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(SomeImage, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
        }

        
    }
}
