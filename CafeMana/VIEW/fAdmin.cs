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
            LoadCategory();
            LoadComboBoxCategories();
            LoadProducts();
        }

        #region Load

        private void LoadCategory()
        {
            List<Category> CategoriesList = Data.Instance.CategoriesList;

            foreach (Category Category in CategoriesList)
            {
                Button btn = new Button();
                btn.Text = Category.Name;
                btn.Size = new System.Drawing.Size(80, 80);
                btn.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Category.Image);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

                btn.Tag = Category.ID;

                CategoriesFlowPanel.Controls.Add(btn);

               // btn.Click += CategoryButtonClick;
            }
        }
        
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

        private void LoadComboBoxCategories()
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
                ProductsGridView.Rows.Add(product.ID, product.Name, product.Price,CategoryBLL.Instance.RetreiveCategory(product.CatagoryID).Name,product.Description,product.Image);                                
            }
        }

        #endregion

        #region Sale

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

        #endregion

        #region Product

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct _AddProduct = new AddProduct();
            _AddProduct.ShowDialog();
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

                        ProductsGridView.Rows.Add(product.ID, product.Name, product.Price, CategoryName, product.Description, product.Image, null, null);

            }
            else
            {
                foreach (Product product in ProductsList)
                
                    if (product.CatagoryID == IDCategory)

                        if (product.Name.Contains(Txt) || product.Price.ToString().Contains(Txt) || product.Description.Contains(Txt))

                            ProductsGridView.Rows.Add(product.ID, product.Name, product.Price, CategoryName, product.Description, product.Image, null, null);
                
            }
        }

        private void ProductsGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            string path = Application.StartupPath;
            path = path.Substring(0, path.IndexOf("bin") - 1);
            path += "\\Image\\editbutton.png";
            Image SomeImage = Image.FromFile(path);
            var w = SomeImage.Width;
            var h = SomeImage.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
            string path2 = Application.StartupPath;
            path2 = path2.Substring(0, path2.IndexOf("bin") - 1);
            path2 += "\\Image\\1212.jpg";
            Image SomeImage2 = Image.FromFile(path2);
            //I supposed your button column is at index 6
            if (e.ColumnIndex == 6)
            {
                e.Graphics.DrawImage(SomeImage, new Rectangle(x, y, w, h));
            }
            if (e.ColumnIndex == 7)
            {
                e.Graphics.DrawImage(SomeImage2, new Rectangle(x, y, w, h));
            }
            e.Handled = true;
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ProductsGridView.Rows[e.RowIndex];        

            if (e.ColumnIndex == 6)
            {
                FormUpdateProduct formUpdateProduct = new FormUpdateProduct();
                formUpdateProduct.Tag = Convert.ToInt32(row.Cells[0].Value);
                formUpdateProduct.ShowDialog();

                Product product= ProductBLL.Instance.RetreiveProducts(Convert.ToInt32(row.Cells[0].Value));
                row.Cells[1].Value = product.Name;
                row.Cells[2].Value = product.Price;
                row.Cells[3].Value = CategoryBLL.Instance.RetreiveCategory(product.CatagoryID).Name;
                row.Cells[4].Value = product.Description;
                row.Cells[5].Value = product.Image;
            }

            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are You Sure You Want to Delete this Product\nfrom Database", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int _ID = Convert.ToInt32(row.Cells[0].Value);
                    ProductBLL.Instance.DeleteProduct(_ID);
                    ProductsGridView.Rows.RemoveAt(e.RowIndex);
                }
            }

        }

        #endregion

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

       
    }
}
