using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMana.DTO
{
    class Category
    {
        int      _ID;
        string   _Name;
        string   _Description;
        byte[]   _Image;

        public int    ID          { get => _ID; set => _ID = value; }
        public string Name        { get => _Name; set => _Name = value; }
        public string Description { get => _Description; set => _Description = value; }
        public byte[] Image       { get => _Image; set => _Image = value; }

    }
}
