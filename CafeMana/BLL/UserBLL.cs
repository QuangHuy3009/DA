using System;
using System.Collections.Generic;
using CafeMana.DTO;
using CafeMana.DAL;
namespace CafeMana.BLL
{
    class UserBLL
    {
        private static UserBLL _Instance;

        internal static UserBLL Instance
        {
            get { if (_Instance == null) _Instance = new UserBLL(); return _Instance; }
            private set { _Instance = value; }
        }

        private UserBLL() { }

        public List<User> RetreiveAllUser()
        {
            return DataAccess.Instance.RetreiveAllUsers();
        }
    }
}
