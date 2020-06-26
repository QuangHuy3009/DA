using CafeMana.BLL;
using CafeMana.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;

namespace CafeMana.VIEW
{
    public partial class FormUpdateProduct : Form
    {
        public FormUpdateProduct()
        {
            InitializeComponent();
        }

        private void FormUpdateProduct_Load(object sender, EventArgs e)
        {
            LoadComboBoxCategories();
            LoadData();
        }

        private void LoadComboBoxCategories()
        {
            List<Category> CategoriesList = Data.Instance.CategoriesList;
            ProductCategoryComboBox.DataSource = CategoriesList;
            ProductCategoryComboBox.DisplayMember = "Name";
        }

        private void LoadData()
        {
            int _ID = (int)this.Tag;
            Product product = Data.Instance.ProductsList.FirstOrDefault(x => x.ID == _ID);

            ProductIDBox.Text           = product.ID.ToString();
            ProductNameBox.Text         = product.Name;
            ProductPriceBox.Text        = product.Price.ToString();
            ProductDescriptionRBox.Text = product.Description;
            MemoryStream ms = new MemoryStream(product.Image);
            ProductPictureBox.Image = Image.FromStream(ms);
            ProductCategoryComboBox.Text = Data.Instance.CategoriesList.FirstOrDefault(x => x.ID == product.CatagoryID).Name;

        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Update This Product?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MemoryStream ms = new MemoryStream();
                ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);

                int _ID             = int.Parse(ProductIDBox.Text);
                string _Name        = ProductNameBox.Text;
                decimal _Price      = decimal.Parse(ProductPriceBox.Text);
                string _Description = ProductDescriptionRBox.Text;
                byte[] _Image       = ms.GetBuffer();
                int   _CategoryID   = ((Category)ProductCategoryComboBox.SelectedValue).ID;

                Product product = new Product() { ID = _ID, Name = _Name, Price = _Price, Description = _Description, Image = _Image, CatagoryID = _CategoryID };

                ProductBLL.Instance.UpdateProduct(product);
            }
          
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                ProductPictureBox.Load(ofd.FileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
