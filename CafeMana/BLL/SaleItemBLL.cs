using System;
using System.Collections.Generic;
using CafeMana.DTO;
using CafeMana.DAL;

namespace CafeMana.BLL
{
    class SaleItemBLL
    {
        private static SaleItemBLL _Instance;

        internal static SaleItemBLL Instance
        {
            get { if (_Instance == null) _Instance = new SaleItemBLL(); return _Instance; }
            private set { _Instance = value; }
        }

        private SaleItemBLL() { }

        public List<SaleItem> RetreiveAllSale()
        {
            return DataAccess.Instance.RetreiveAllSaleItems();
        }

        public int RetreiveSaleItemID()
        {
            int ID = 0;
            foreach (SaleItem saleItem in Data.Instance.SaleItemsList)
            {
                if (saleItem.ID > ID) ID = saleItem.ID;
            }
            return ID + 1;
        }

        public void AddNewSaleItem(SaleItem saleItem)
        {
            Data.Instance.SaleItemsList.Add(saleItem);
            DataAccess.Instance.AddNewSaleItem(saleItem);
        }
    }
}
