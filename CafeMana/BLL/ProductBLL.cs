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

        public List<Product> RetreiveProductsFromCategory(int IDCategory)
        {
            List<Product> ProductsList = new List<Product>();
            foreach (Product product in Data.Instance.ProductsList)
            {
                if (product.CatagoryID == IDCategory) ProductsList.Add(product);
            }
            return ProductsList;
        }

        public int  RetreiveProductID()
        {
            return ++Data.Instance.IdentityProduct;
        }

        public int  RetreiveIdentityProduct()
        {
            return DataAccess.Instance.RetreiveIdentityProduct();
        }

        public bool AddNewProduct(Product product)
        {
            if (DataAccess.Instance.AddNewProduct(product))
            { 
                Data.Instance.ProductsList.Add(product);
                return true;
            }
            return false;
        }

        public bool UpdateProduct(Product product)
        {
            if (DataAccess.Instance.UpdateProduct(product))
            {
                List<Product> ProductsList = Data.Instance.ProductsList;

                for (int i = 0; i < ProductsList.Count; i++)
                {
                    if (ProductsList[i].ID == product.ID) { ProductsList[i] = product; break; }
                }
            return true;
            }
            return false;          
          
        }

        public bool DeleteProduct(int ID)
        {
            if (DataAccess.Instance.DeleteSomething(ID, "Products"))
            {
                List<Product> ProductsList = Data.Instance.ProductsList;
                int Index = 0;
                for (int i = 0; i < ProductsList.Count; i++)
                {
                    if (ProductsList[i].ID == ID) { Index = i; break; }
                }
                ProductsList.RemoveAt(Index);
                return true;
            }
            return false;
           
        }
    }
}
