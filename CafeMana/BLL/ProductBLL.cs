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

        public void AddNewProduct(Product product)
        {
         
            Data.Instance.ProductsList.Add(product);
            DataAccess.Instance.AddNewProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            List<Product> ProductsList = Data.Instance.ProductsList;

            for (int i=0;i< ProductsList.Count; i++)
            {
                if (ProductsList[i].ID == product.ID) { ProductsList[i] = product; break; }
            }
           
            DataAccess.Instance.UpdateProduct(product);
        }

        public void DeleteProduct(int ID)
        {
            List<Product> ProductsList = Data.Instance.ProductsList;
            int Index = 0;
            for (int i = 0; i < ProductsList.Count; i++)
            {
                if (ProductsList[i].ID == ID) { Index=i; break; }
            }
            ProductsList.RemoveAt(Index);
            DataAccess.Instance.DeleteSomething(ID,"Products");
        }
    }
}
