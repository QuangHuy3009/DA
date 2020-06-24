using System;
using System.Collections.Generic;
using CafeMana.DTO;

namespace CafeMana.BLL
{
    class Data
    {
        private static Data _Instance;

        internal static Data Instance
        {
            get { if (_Instance == null) _Instance = new Data(); return _Instance; }
        }

        public  List<Sale>     SalesList      { get; set; }
        public  List<SaleItem> SaleItemsList  { get; set; }
        public  List<User>     UsersList      { get; set; }
        public  List<Category> CategoriesList { get; set; }
        public  List<Product>  ProductsList   { get; set; }

        private Data()
        {
            SalesList      = SaleBLL.Instance.RetreiveAllSale();
            SaleItemsList  = SaleItemBLL.Instance.RetreiveAllSale();
            UsersList      = UserBLL.Instance.RetreiveAllUser();
            CategoriesList = CategoryBLL.Instance.RetreiveAllCategories();
            ProductsList = ProductBLL.Instance.RetreiveAllProducts();
        }

        
    }
}
