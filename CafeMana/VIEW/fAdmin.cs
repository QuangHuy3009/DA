﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMana.VIEW
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

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
    }
}
