using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMana.DTO
{
    class SaleItem
    {
        int     _ID;
        int     _SaleID;
        string  _ProductName;
        decimal _ProductPrice;
        int     _ProductQuantity;
        decimal _ProductTotal;

        public int     ID              { get => _ID; set => _ID = value; }
        public int     SaleID          { get => _SaleID; set => _SaleID = value; }
        public string  ProductName     { get => _ProductName; set => _ProductName = value; }
        public decimal ProductPrice    { get => _ProductPrice; set => _ProductPrice = value; }
        public int     ProductQuantity { get => _ProductQuantity; set => _ProductQuantity = value; }
        public decimal ProductTotal    { get => _ProductTotal; set => _ProductTotal = value; }
    }
}
