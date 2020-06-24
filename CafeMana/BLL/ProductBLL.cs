using System;
using System.Collections.Generic;
using CafeMana.DTO;
using CafeMana.DAL;

namespace CafeMana.BLL
{
    class ProductBLL
    {
        private static ProductBLL _Instance;

        internal static ProductBLL Instance
        {
            get { if (_Instance == null) _Instance = new ProductBLL(); return _Instance; }
        }

        private ProductBLL() { }

        public List<Product> RetreiveAllProducts()
        {
            return DataAccess.Instance.RetreiveAllProducts();
        }
    }
}
