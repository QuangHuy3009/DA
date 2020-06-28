using CafeMana.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMana
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UsernameEmail = UserNameTxt.Text;
            string Password = PasswordTxt.Text;
            if (ConfirmEmailAddress(UsernameEmail) && ConfirmPassword(Password))
            {
                if (DAL.DataAccess.Instance.ConfirmUser(UsernameEmail, Password))
                {
                    int UserID = Convert.ToInt32(DAL.DataAccess.Instance.ReturnUserID(UsernameEmail));
                    FormGeneral f1 = new FormGeneral(UserID);
                    this.Hide();
                    f1.Show();
                    
                }
                else
                {
                    MessageBox.Show("Sai UsernameEmail hoặc mật khẩu ");
                }

            }


        }
        public bool ConfirmEmailAddress(string UserEmail)
        {
            var EmailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return EmailRegex.IsMatch(UserEmail);
        }
        public bool ConfirmPassword(string UserPassword)
        {
            UserPassword = UserPassword.Trim();
            if (UserPassword == string.Empty)
            {
                return false;
            }
            else return true;
        }
    }
}
