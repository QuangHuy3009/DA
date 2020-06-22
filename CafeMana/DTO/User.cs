using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMana.DTO
{
    class User
    {
        int    _ID;
        string _Name;
        string _Role;
        string _Email;
        string _Password;

        public int    ID       { get => _ID; set => _ID = value; }
        public string Name     { get => _Name; set => _Name = value; }
        public string Role     { get => _Role; set => _Role = value; }
        public string Email    { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
    }
}
