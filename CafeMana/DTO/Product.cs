using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMana.DTO
{
    class Product
    {
        int     _ID;
        string  _Name;
        decimal _Price;
        int     _CatagoryID;
        string  _Description;
        byte[]  _Image;

        public int     ID          { get => _ID; set => _ID = value; }
        public string  Name        { get => _Name; set => _Name = value; }
        public decimal Price       { get => _Price; set => _Price = value; }
        public int     CatagoryID  { get => _CatagoryID; set => _CatagoryID = value; }
        public string  Description { get => _Description; set => _Description = value; }
        public byte[]  Image       { get => _Image; set => _Image = value; }
    }
}
