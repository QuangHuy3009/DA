using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CafeMana.DTO;

namespace CafeMana.DAL
{
    class DataAccess
    {
        private static DataAccess _Instance;

        internal static DataAccess Instance { get { if (_Instance == null) _Instance = new DataAccess(); return _Instance; } private set { _Instance = value; } }

        private DataAccess() { }

        public List<Sale> RetreiveAllSales()
        {
            List<Sale> SalesList = new List<Sale>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Sales;", connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int _ID = reader.GetInt32(0);
                            DateTime _Time = reader.GetDateTime(1);
                            int _SalesmanID = reader.GetInt32(2);
                            decimal _CashGiven = reader.GetDecimal(3);
                            decimal _Total = reader.GetDecimal(4);
                            decimal _CashReturn = reader.GetDecimal(5);

                            SalesList.Add(new Sale() { ID = _ID, Time = _Time, SalesManID = _SalesmanID, Total = _Total, CashGiven = _CashGiven, CashReturn = _CashReturn });
                        }
                    }
                    reader.Close();

                    return SalesList;

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
              
            }
        }

        public List<User> RetreiveAllUsers()
        {
            List<User> UsersList = new List<User>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _ID           = reader.GetInt32(0);
                        string _Name     = reader.GetString(1);
                        string _Role     = reader.GetString(2);
                        string _Email    = reader.GetString(3);
                        string _Password = reader.GetString(4);

                        UsersList.Add(new User() { ID = _ID, Name=_Name,Role=_Role,Email=_Email,Password=_Password });
                    }
                }
                reader.Close();

                return UsersList;
            }
        }

        public List<SaleItem> RetreiveAllSaleItems()
        {
            List<SaleItem> SaleItemsList = new List<SaleItem>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SaleItems;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _ID                 = reader.GetInt32(0);
                        string _ProductName     = reader.GetString(1);
                        decimal _ProductPrice   = reader.GetDecimal(2);
                        int _ProductQuantity    = reader.GetInt32(3);
                        decimal _ProductTotal   = reader.GetDecimal(4);
                        int _SaleID             = reader.GetInt32(5);

                        SaleItemsList.Add(new SaleItem() {ID=_ID,ProductName=_ProductName,ProductPrice=_ProductPrice,ProductQuantity=_ProductQuantity,ProductTotal=_ProductTotal,SaleID=_SaleID});
                    }
                }
                reader.Close();

                return SaleItemsList;
            }
        }

        public List<Category> RetreiveAllCategories()
        {
            List<Category> CategoriesList = new List<Category>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Categories;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int    _ID         =reader.GetInt32(0);
                        string _Name       =reader.GetString(1);
                        string _Description=reader.GetString(2);
                        byte[] _Image      = (byte[])reader[3];

                        CategoriesList.Add(new Category() {  ID=_ID,Name=_Name,Description=_Description,Image=_Image});
                    }
                }
                reader.Close();

                return CategoriesList;
            }
        }

        public List<Product> RetreiveAllProducts()
        {
            List<Product> ProductsList = new List<Product>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Products;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _ID             =reader.GetInt32(0);
                        string _Name        =reader.GetString(1);
                        decimal _Price      =reader.GetDecimal(2);
                        int _CatagoryID     =reader.GetInt32(3);
                        string _Description =reader.GetString(4);
                        byte[] _Image       =(byte[])reader[5];


                        ProductsList.Add(new Product() { ID = _ID, Name = _Name, Description = _Description, Image = _Image, CatagoryID = _CatagoryID, Price=_Price });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }
        public List<Product> RetreiveProductsFromCategory(int CategoryID)
        {
            List<Product> ProductsList = new List<Product>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID, ProductName, ProductPrice, ProductDescription, ProductImage FROM Products where ProductCategoryID = '" + CategoryID + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int ProductID = reader.GetInt32(0);
                        string ProductName = reader.GetString(1);
                        decimal ProductPrice = reader.GetDecimal(2);
                        string ProductDescription = reader.GetString(3);
                        byte[] ProductPicture = (byte[])reader[4];

                        ProductsList.Add(new Product() { ID = ProductID, Name = ProductName, Price = ProductPrice, Image = ProductPicture, Description = ProductDescription });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }
    }
}
