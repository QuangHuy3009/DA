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
    }
}
