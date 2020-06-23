using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B8N6V6G;Initial Catalog=QuanLyCaPhe1;Integrated Security=True")) 
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Sales;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int _ID              = reader.GetInt32(0);
                        DateTime _Time       = reader.GetDateTime(1);
                        int _SalesmanID      = reader.GetInt32(2);
                        decimal _CashGiven   = reader.GetDecimal(3);
                        decimal _Total       = reader.GetDecimal(4);
                        decimal _CashReturn  = reader.GetDecimal(5);

                        SalesList.Add(new Sale() { ID = _ID, Time = _Time, SalesManID = _SalesmanID,Total= _Total,CashGiven=_CashGiven,CashReturn=_CashReturn });
                    }
                }
                reader.Close();

                return SalesList;
            }
        }

        public List<User> RetreiveAllUsers()
        {
            List<User> UsersList = new List<User>();

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B8N6V6G;Initial Catalog=QuanLyCaPhe1;Integrated Security=True"))
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

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B8N6V6G;Initial Catalog=QuanLyCaPhe1;Integrated Security=True"))
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
    }
}
