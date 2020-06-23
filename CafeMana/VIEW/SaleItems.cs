using System;
using CafeMana.BLL;
using System.Windows.Forms;
using System.Collections.Generic;
using CafeMana.DTO;

namespace CafeMana.VIEW
{
    public partial class SaleItems : Form
    {
        public SaleItems()
        {
            InitializeComponent();
        }

        private void SaleItems_Load(object sender, EventArgs e)
        {
            LoadSaleItems();
        }

        private void LoadSaleItems()
        {
            int SaleID = (int)this.Tag;
            List<SaleItem> SaleItemsList = Data.Instance.SaleItemsList;
            foreach (SaleItem saleItem in SaleItemsList)
            {
                if(saleItem.SaleID==SaleID)
                SaleItemsGridView.Rows.Add(saleItem.ProductName,saleItem.ProductPrice,saleItem.ProductQuantity,saleItem.ProductTotal);
            }
        }
    }
}
