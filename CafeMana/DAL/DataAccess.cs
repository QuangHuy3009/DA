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
                        int _ID = reader.GetInt32(0);
                        string _Name = reader.GetString(1);
                        string _Role = reader.GetString(2);
                        string _Email = reader.GetString(3);
                        string _Password = reader.GetString(4);

                        UsersList.Add(new User() { ID = _ID, Name = _Name, Role = _Role, Email = _Email, Password = _Password });
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
                        int _ID = reader.GetInt32(0);
                        string _ProductName = reader.GetString(1);
                        decimal _ProductPrice = reader.GetDecimal(2);
                        int _ProductQuantity = reader.GetInt32(3);
                        decimal _ProductTotal = reader.GetDecimal(4);
                        int _SaleID = reader.GetInt32(5);

                        SaleItemsList.Add(new SaleItem() { ID = _ID, ProductName = _ProductName, ProductPrice = _ProductPrice, ProductQuantity = _ProductQuantity, ProductTotal = _ProductTotal, SaleID = _SaleID });
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
                        int _ID = reader.GetInt32(0);
                        string _Name = reader.GetString(1);
                        string _Description = reader.GetString(2);
                        byte[] _Image = (byte[])reader[3];

                        CategoriesList.Add(new Category() { ID = _ID, Name = _Name, Description = _Description, Image = _Image });
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
                        int _ID = reader.GetInt32(0);
                        string _Name = reader.GetString(1);
                        decimal _Price = reader.GetDecimal(2);
                        int _CatagoryID = reader.GetInt32(3);
                        string _Description = reader.GetString(4);
                        byte[] _Image = (byte[])reader[5];


                        ProductsList.Add(new Product() { ID = _ID, Name = _Name, Description = _Description, Image = _Image, CatagoryID = _CatagoryID, Price = _Price });
                    }
                }
                reader.Close();

                return ProductsList;
            }
        }


        public void AddNewProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@ProductName",  product.Name);
                command.Parameters.AddWithValue("@ProductPrice", product.Price);
                command.Parameters.AddWithValue("@ProductCategoryID",  product.CatagoryID);
                command.Parameters.AddWithValue("@ProductDescription", product.Description);
                command.Parameters.AddWithValue("@ProductImage", product.Image);
                command.CommandText = "Insert Into Products(ProductName, ProductPrice, ProductCategoryID, ProductDescription, ProductImage) Values (@ProductName,@ProductPrice,@ProductCategoryID,@ProductDescription,@ProductImage)";
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@ProductName", product.Name);
                command.Parameters.AddWithValue("@ProductPrice", product.Price);
                command.Parameters.AddWithValue("@ProductCategoryID", product.CatagoryID);
                command.Parameters.AddWithValue("@ProductDescription", product.Description);
                command.Parameters.AddWithValue("@ProductImage", product.Image);
                command.CommandText = "Update Products Set ProductName=@ProductName,ProductPrice=@ProductPrice,ProductCategoryID=@ProductCategoryID,ProductDescription=@ProductDescription,ProductImage=@ProductImage Where ID="+product.ID+" ";
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public bool DeleteSomething(int ID, string s)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "Delete " + s + " Where ID=" + ID + " ";
                    MessageBox.Show(command.CommandText);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Ban phai xoa Product truoc khi xoa Category!!");
                return false;
            }
        }


        public void AddNewSale(Sale sale)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@SaleTime",   sale.Time);
                command.Parameters.AddWithValue("@SalesManID",  sale.SalesManID);
                command.Parameters.AddWithValue("@CashGiven",  sale.CashGiven);
                command.Parameters.AddWithValue("@TotalBill",  sale.Total);
                command.Parameters.AddWithValue("@CashReturn", sale.CashReturn);
                command.CommandText = "Insert Into Sales(SaleTime, SalesManID, CashGiven, TotalBill, CashReturn) Values (@SaleTime,@SalesManID,@CashGiven,@TotalBill,@CashReturn)";
                command.ExecuteNonQuery();
                connection.Close();

            }

        }


        public void AddNewSaleItem(SaleItem saleItem)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@ProductName", saleItem.ProductName);
                command.Parameters.AddWithValue("@ProductPrice", saleItem.ProductPrice);
                command.Parameters.AddWithValue("@ProductQuantity", saleItem.ProductQuantity);
                command.Parameters.AddWithValue("@ProductTotal", saleItem.ProductTotal);
                command.Parameters.AddWithValue("@SaleID", saleItem.SaleID);
                command.CommandText = "Insert Into SaleItems(ProductName, ProductPrice, ProductQuantity, ProductTotal, SaleID) Values (@ProductName,@ProductPrice,@ProductQuantity,@ProductTotal,@SaleID)";
                command.ExecuteNonQuery();
                connection.Close();

            }

        }


        public void AddNewCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@CategoryName", category.Name);
                command.Parameters.AddWithValue("@CategoryDescription", category.Description);
                command.Parameters.AddWithValue("@CategoryPicture", category.Image);
                command.CommandText = "Insert Into Categories(CategoryName, CategoryDescription, CategoryPicture) Values (@CategoryName,@CategoryDescription,@CategoryPicture)";
                MessageBox.Show(command.CommandText);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        public void UpdateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@CategoryName", category.Name);
                command.Parameters.AddWithValue("@CategoryDescription", category.Description);
                command.Parameters.AddWithValue("@CategoryPicture", category.Image);
                command.Parameters.AddWithValue("@CategoryID", category.ID);
                command.CommandText = "Update Categories set CategoryName=@CategoryName , CategoryDescription= @CategoryDescription , CategoryPicture=@CategoryPicture  where ID= @CategoryID";
                System.Console.WriteLine(command.CommandText);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

    }

}
