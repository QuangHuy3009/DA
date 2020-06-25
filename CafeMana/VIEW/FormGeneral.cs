using CafeMana.BLL;
using CafeMana.DAL;
using CafeMana.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMana.VIEW
{
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();
            LoadCategory();
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

                btn.Click += CategoryButtonClick;
            }

        }

        #endregion

        #region Event

        private void CategoryButtonClick(object sender, EventArgs e)
        {
            ProductsFlowPanel.Controls.Clear();

            Button btn = (Button)sender;

            int CategoryID = Convert.ToInt32(btn.Tag);

            List<Product> ProductsList = Data.Instance.ProductsList;
            foreach (Product Product in ProductBLL.Instance.RetreiveProductsFromCategory(CategoryID))
            {
                Button ProductButton = new Button();
                ProductButton.Text = Product.Name;
                ProductButton.Size = new System.Drawing.Size(80, 80);
                ProductButton.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Product.Image);
                ProductButton.Image = Image.FromStream(ms);
                ProductButton.Image = new Bitmap(ProductButton.Image, ProductButton.Size);

                ProductButton.Tag = Product.ID;

                ProductsFlowPanel.Controls.Add(ProductButton);

                //ProductButton.Click += ProductButton_Click;

                //ProductButton.MouseClick += ProductButton_MouseClick;
            }
        }

        private void AdmintoolStrip_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void AccountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }
        
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CashForm f = new CashForm();
            f.ShowDialog();
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
    }
}
