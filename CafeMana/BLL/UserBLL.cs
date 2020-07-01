using System;
using System.Linq;
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

        public int RetreiveUserID()
        {         
            return ++Data.Instance.IdentityUser;
        }

        public int RetreiveIdentityUser()
        {
           return  DataAccess.Instance.RetreiveIdentityUser();
        }

        public List<User> RetreiveAllUser()
        {
            return DataAccess.Instance.RetreiveAllUsers();
        }

        public void AddNewUser(User user)
        {
            Data.Instance.UsersList.Add(user);
            DataAccess.Instance.AddNewUser(user);
        }

        public void UpdateUser(User user)
        {
            List<User> UsersList = Data.Instance.UsersList;

            for (int i = 0; i < UsersList.Count; i++)
            {
                if (UsersList[i].ID == user.ID) { UsersList[i] = user; break; }
            }

            DataAccess.Instance.UpdateUser(user);
        }

        public bool ConfirmUser(string UsernameEmail, string Password)
        {
            string _Password = Data.Instance.UsersList.FirstOrDefault(x=>x.Email==UsernameEmail).Password;
            var hash = new CafeMana.DTO.Hash();
            string st = hash.MD5(Password);
            if (_Password == hash.MD5(Password)) return true;
            else return false;  
        }

    }
}
