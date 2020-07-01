using System;
using System.Collections.Generic;
using CafeMana.DAL;
using CafeMana.DTO;

namespace CafeMana.BLL
{
    class SaleBLL
    {
        private static SaleBLL _Instance;

        internal static SaleBLL Instance
        {
            get { if (_Instance == null) _Instance = new SaleBLL(); return _Instance; } private set { _Instance = value; }
        }

        private SaleBLL() {}
        
        public List<Sale> RetreiveAllSale()
        {
            return DataAccess.Instance.RetreiveAllSales();
        }

        public int RetreiveSaleID()
        {
            int ID=0;
            foreach(Sale sale in Data.Instance.SalesList)
            {
                if (sale.ID > ID) ID = sale.ID;
            }
            return ID+1;
        }

        public bool AddNewSale(Sale sale)
        {
            if (DataAccess.Instance.AddNewSale(sale))
            {
                Data.Instance.SalesList.Add(sale);
                return true;
            }
            return false;                 
        }
    }
}
