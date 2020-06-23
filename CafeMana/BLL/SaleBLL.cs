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
    }
}
