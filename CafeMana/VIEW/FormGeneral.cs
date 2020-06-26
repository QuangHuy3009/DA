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

        #region Oder

        public int RowIndex = 0;

        public bool    CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ID"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["ProductTotal"].Value);


                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        private void   CategoryButtonClick(object sender, EventArgs e)
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

                ProductButton.Click += ProductButton_Click;

                //    ProductButton.MouseClick += ProductButton_MouseClick;
            }
        }

        private void   ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;


            int ProductID = Convert.ToInt32(ProductButton.Tag);

            //  Product ProductDetails = _DataAccess.RetreiveProductDetails(ProductID);
            var ProductDetails = Data.Instance.ProductsList.FirstOrDefault(x => x.ID == ProductID);
            if (CheckProductAlreadyAdded(ProductID))
            {
                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity  = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductQuantity"].Value);
                decimal Price = Convert.ToDecimal(ProductsGridView.Rows[RowIndex].Cells["ProductPrice"].Value);

                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                ProductsGridView.Rows[RowIndex].Cells["ProductQuantity"].Value = Quantity;
                ProductsGridView.Rows[RowIndex].Cells["ProductTotal"].Value = TotalPrice;



                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
        }

        private void   ProductsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                decimal price = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["ProductPrice"].Value);
                int quality   = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductQuantity"].Value);
                ProductsGridView.Rows[e.RowIndex].Cells["ProductTotal"].Value = price * quality;
                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
        }
    
        private void   ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["ProductTotal"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(TotalBillBox.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        TotalBillBox.Text = CurrentTotalBill.ToString();
                    }
                }
            }
        }

        private void   CheckOutButton_Click(object sender, EventArgs e)
        {
            CashForm f = new CashForm();
            f.Tag = ProductsGridView;
            f.ShowDialog();

        }

        #endregion

        #region ButtonDeleteForProductGridView

        private void ProductsGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                string path = Application.StartupPath;
                path = path.Substring(0, path.IndexOf("bin") - 1);
                path += "\\Image\\1212.jpg";
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


        //
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

      

    }
}
