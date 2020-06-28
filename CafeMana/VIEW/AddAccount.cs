using System;
using CafeMana.DTO;
using CafeMana.BLL;
using System.Windows.Forms;

namespace CafeMana.VIEW
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txbUserName.Text.Trim().Length>0 && txbPassword.Text.Trim().Length > 0 && txbEmail.Text.Trim().Length > 0 && cbBoxRole.Text.Length>0 && txbPassword.Text==txbConfirm.Text)
                {
                    int    _ID       = UserBLL.Instance.RetreiveUserID();
                    string _UserName = txbUserName.Text;
                    var h1 = new DTO.Hash();
                    string _Password = h1.MD5(txbPassword.Text);
                    string _Email    = txbEmail.Text;
                    string _Role     = cbBoxRole.Text;

                    UserBLL.Instance.AddNewUser(new User() { ID = _ID, Name = _UserName, Role = _Role, Email = _Email, Password = _Password });
                    MessageBox.Show("Successfully!");
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


    }
}
