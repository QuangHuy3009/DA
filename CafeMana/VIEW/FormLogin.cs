using CafeMana.VIEW;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CafeMana.BLL;
using System.Linq;
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string UsernameEmail = UserNameTxt.Text;
            string Password = PasswordTxt.Text;

            if (ConfirmEmailAddress(UsernameEmail) && ConfirmPassword(Password))
            {
                if (UserBLL.Instance.ConfirmUser(UsernameEmail, Password))
                {
                    Data.Instance.User = Data.Instance.UsersList.FirstOrDefault(x => x.Email == UsernameEmail);
                    FormGeneral f1 = new FormGeneral();
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("UsernameEmail Or Password Is Incorrect");

            }
            else MessageBox.Show("UsernameEmail Or Password Is Incorrect");

        }

        public bool  ConfirmEmailAddress(string UserEmail)
        {
            var EmailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return EmailRegex.IsMatch(UserEmail);
        }

        public bool  ConfirmPassword(string UserPassword)
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
