﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CafeMana.DTO;
using CafeMana.BLL;
using System.IO;

namespace CafeMana.VIEW
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadComboBoxCategories();

        }

        private void LoadComboBoxCategories()
        {
            List<Category> CategoriesList = Data.Instance.CategoriesList;          
            ProductCategoryComboBox.DataSource = CategoriesList;
            ProductCategoryComboBox.DisplayMember = "Name";
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);

                int _ID              = ProductBLL.Instance.RetreiveProductID();
                string  _Name        = txtProductName.Text;
                decimal _Price       = decimal.Parse(txtProductPrice.Text);
                string  _Description = rbProductDescription.Text;
                byte[]  _Image       = ms.GetBuffer();
                int     _CategoryID  = ((Category)ProductCategoryComboBox.SelectedValue).ID;
                Product product      = new Product() {ID=_ID,Name=_Name,Price=_Price,Description=_Description,Image=_Image,CatagoryID=_CategoryID};
                if (_Name.Trim().Length <= 0 || _Price.ToString().Trim().Length <= 0 || _Description.Trim().Length <= 0) throw null;
                if(ProductBLL.Instance.AddNewProduct(product)) MessageBox.Show("Them Thanh Cong!");
                else                                           MessageBox.Show("Them That Bai!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Phai Nhap Day Du Thong Tin!");
            }
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title      = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter     = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)           
                ProductPictureBox.Load(ofd.FileName);
            
        }

        
    }
}
