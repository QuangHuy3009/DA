﻿using System;
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
            LoadProducts();
        }

        #region Load

        private void LoadCategory()
        {
            CategoriesFlowPanel.Controls.Clear();
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

                btn.Click += CategoryButton_Click;
            }
        }
        
        private void LoadUser()
        {
            List<User> UsersList = Data.Instance.UsersList;
            UsersGridView.Rows.Clear();
            foreach (User user in UsersList)
            {
                UsersGridView.Rows.Add(user.ID, user.Name, user.Role,user.Email);
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
            ProductCategoryComboBox.DataSource = null;
            ProductCategoryComboBox.DataSource = CategoriesList;
            ProductCategoryComboBox.DisplayMember = "Name";

        }

        private void LoadProducts()
        {
            ProductsGridView.Rows.Clear();
            LoadComboBoxCategories();
            List<Product>  ProductsList = Data.Instance.ProductsList;
            foreach (Product product in ProductsList)
            {
                ProductsGridView.Rows.Add(product.ID, product.Name, product.Price, Data.Instance.CategoriesList.FirstOrDefault(x => x.ID ==product.CatagoryID).Name,product.Description,product.Image);                                
            }
        }

        #endregion

        #region Sale

        public delegate void ViewClicked();
        public event ViewClicked EventViewClicked;

        void DaClickView() { }

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
                        if (user.ID == sale.SalesManID) { SalesGridView.Rows.Add(sale.ID, sale.Time, user.Name, sale.Total, null); break; }
                    }
                }

            }
            EventViewClicked += DaClickView;
        }
        // KetXuat excel
        private DataTable ConvertToDt()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < SalesGridView.ColumnCount - 1; i++)
                dt.Columns.Add(SalesGridView.Columns[i].HeaderText);
            for (int i = 0; i < SalesGridView.Rows.Count; i++)
                dt.Rows.Add(SalesGridView.Rows[i].Cells[0].Value, SalesGridView.Rows[i].Cells[1].Value, SalesGridView.Rows[i].Cells[2].Value, SalesGridView.Rows[i].Cells[3].Value);
            return dt;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            if (EventViewClicked != null && SalesGridView.Rows.Count > 1)
            {

                excel.Export(ConvertToDt(), "Bill", dateTimePicker1.Value.ToString());
            }
            else if (EventViewClicked == null)
            {
                excel.Export(ConvertToDt(), "AllBill", "(Tất cả)");
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
            LoadProducts();


        }

        private void buttonFindProduct_Click(object sender, EventArgs e)
        {
            ProductsGridView.Rows.Clear();
            List<Product> ProductsList = Data.Instance.ProductsList;
            int IDCategory             = ((Category)ProductCategoryComboBox.SelectedValue).ID;
            string CategoryName        = ((Category)ProductCategoryComboBox.SelectedValue).Name;
            string Txt                 = txbFindProduct.Text.ToLower();

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

                        if (product.Name.ToLower().Contains(Txt) || product.Price.ToString().ToLower().Contains(Txt) || product.Description.ToLower().Contains(Txt))

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
                
                int _ID= Convert.ToInt32(row.Cells[0].Value);
                Product product = Data.Instance.ProductsList.FirstOrDefault(x => x.ID == _ID);
                row.Cells[1].Value = product.Name;
                row.Cells[2].Value = product.Price;
                row.Cells[3].Value = Data.Instance.CategoriesList.FirstOrDefault(x => x.ID ==product.CatagoryID).Name;
                row.Cells[4].Value = product.Description;
                row.Cells[5].Value = product.Image;
            }

            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are You Sure You Want to Delete this Product\nfrom Database", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int _ID = Convert.ToInt32(row.Cells[0].Value);
                        if (ProductBLL.Instance.DeleteProduct(_ID)) { ProductsGridView.Rows.RemoveAt(e.RowIndex); MessageBox.Show("Xoa Thanh Cong!");}
                        else                                          MessageBox.Show("Xoa That Bai!");
                    }
                    catch
                    {

                    }
                }
            }

        }
       
        #endregion

        #region Category

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory _AddCategory = new AddCategory();
            _AddCategory.ShowDialog();
            LoadCategory();
            LoadComboBoxCategories();
        }

        static int   indexCate = -1;

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            indexCate = (sender as Button).TabIndex;
            int ID = (int)(sender as Button).Tag;
            Category category = Data.Instance.CategoriesList.FirstOrDefault(x => x.ID == ID);
            CategoryIDBox.Text = category.ID.ToString();
            CategoryNameBox.Text = category.Name;
            CategoryDescriptionRBox.Text = category.Description;
            MemoryStream ms = new MemoryStream(category.Image);
            CategoryPictureBox.Image = Image.FromStream(ms);
        }
        
        private void buttonDelCate_Click(object sender, EventArgs e)
        {
            if (indexCate >= 0)
            {
                if (MessageBox.Show("Are You Sure!", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ID = int.Parse(CategoryIDBox.Text.ToString());
                    if(CategoryBLL.Instance.DeleteCategory(ID)) MessageBox.Show("Xoa Thanh Cong!");
                    else                                        MessageBox.Show("Xoa That Bai!");
                    LoadCategory();
                    LoadComboBoxCategories();
                }
            }
        }
      
        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) CategoryPictureBox.Load(ofd.FileName);

        }

        private void buttonEditCate_Click(object sender, EventArgs e)
        {
            try
            {   if (indexCate >= 0)
                {
                    if (CategoryNameBox.Text.Trim().Length >0 && CategoryDescriptionRBox.Text.Trim().Length > 0)
                    {
                        MemoryStream ms = new MemoryStream();
                        CategoryPictureBox.Image.Save(ms, CategoryPictureBox.Image.RawFormat);

                        int _ID = int.Parse(CategoryIDBox.Text);
                        string _Name = CategoryNameBox.Text;
                        string _Description = CategoryDescriptionRBox.Text;
                        byte[] _Image = ms.GetBuffer();

                        Category category = new Category() { ID = _ID, Name = _Name, Description = _Description, Image = _Image };
                        if (CategoryBLL.Instance.UpdateCategory(category)) MessageBox.Show("Cap Nhat Thanh Cong!");
                        else                                               MessageBox.Show("Cap Nhat That Bai!");
                        LoadCategory();
                        LoadProducts();
                    }
                    else MessageBox.Show("Nhap Thieu Thong Tin!");
                }

            }
            catch
            {
                MessageBox.Show("Nhap Thieu Thong Tin!");
            }
        }

        #endregion

        #region User

        private void buttonAddAcc_Click(object sender, EventArgs e)
        {
            AddAccount _AddAccount = new AddAccount();
            _AddAccount.ShowDialog();
            LoadUser();
        }

        private void buttonEditAcc_Click(object sender, EventArgs e)
        {

            if (indexUser >= 0)
            {
                if (MessageBox.Show("Are You Sure!", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int _ID = (int)(sender as Button).Tag;
                    User user = Data.Instance.UsersList.FirstOrDefault(x => x.ID == _ID);

                    if (txbUserName.Text.Trim().Length > 0 && txbPassword.Text.Trim().Length > 0)
                    {
                        if (txbPassword.Text != user.Password)
                        {
                            user.Name = txbUserName.Text;
                            user.Role = cbBoxRole.Text;
                            var hash = new Hash();
                            user.Password = hash.MD5(txbPassword.Text);
                            if (UserBLL.Instance.UpdateUser(user)) MessageBox.Show("Cap Nhat Thanh Cong!");
                            else MessageBox.Show("Cap Nhat That Bai!");
                        }
                        else
                        {
                            user.Name = txbUserName.Text;
                            user.Role = cbBoxRole.Text;
                            if (UserBLL.Instance.UpdateUser(user)) MessageBox.Show("Cap Nhat Thanh Cong!");
                            else MessageBox.Show("Cap Nhat That Bai!");
                            

                        }
                        LoadUser();
                        LoadSale();
                    }
                    else MessageBox.Show("Nhap Thieu Thong Tin!");
                }
            }
        }

        static int   indexUser = -1;

        private void UsersGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexUser = e.RowIndex;
            int ID    = Convert.ToInt32(UsersGridView.Rows[e.RowIndex].Cells["ID"].Value);
            User user = Data.Instance.UsersList.FirstOrDefault(x => x.ID == ID);
            txbUserName.Text  = user.Name;
            txbPassword.Text  = user.Password;
            cbBoxRole.Text    = user.Role;
            buttonEditAcc.Tag = ID;
           
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            UsersGridView.Rows.Clear();
            List<User> UsersList = Data.Instance.UsersList;
            string     Txt       = txbFindUser.Text.ToLower();

            if (Txt == "") LoadUser();
            else
            {
                foreach (User user in UsersList)
                {
                    string Name = user.Name.ToLower();
                    string Role = user.Role.ToLower();
                    string Email = user.Email.ToLower();
                    if (Name.Contains(Txt) || Role.Contains(Txt) || Email.Contains(Txt) || ID.ToString().Contains(Txt))
                        UsersGridView.Rows.Add(user.ID, user.Name, user.Role, user.Email);
                }
            }
        }

        #endregion

    }
}
