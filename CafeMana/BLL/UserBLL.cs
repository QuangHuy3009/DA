using System;
using System.Linq;
using System.Collections.Generic;
using CafeMana.DTO;
using CafeMana.DAL;
using System.Windows.Forms;

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

        public bool AddNewUser(User user)
        {
            if (DataAccess.Instance.AddNewUser(user))
            {
                Data.Instance.UsersList.Add(user);
                return true;
            }
            return false;

        }

        public bool UpdateUser(User user)
        {
            List<User> UsersList = Data.Instance.UsersList;
            if (DataAccess.Instance.UpdateUser(user))
            {
                for (int i = 0; i < UsersList.Count; i++)
                {
                    if (UsersList[i].ID == user.ID) { UsersList[i] = user; break; }
                }
                return true;
            }
            return false;
         
        }

        public bool ConfirmUser(string UsernameEmail, string Password)
        {
            try
            {
                string _Password = Data.Instance.UsersList.FirstOrDefault(x => x.Email == UsernameEmail).Password.Trim();
                var hash = new CafeMana.DTO.Hash();
                string st = hash.MD5(Password).Trim();
                if (_Password == st) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
