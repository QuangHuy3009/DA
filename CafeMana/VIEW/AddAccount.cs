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
                if (txbUserName.Text.Trim().Length > 0 && txbPassword.Text.Trim().Length > 0 && txbEmail.Text.Trim().Length > 0 && cbBoxRole.Text.Length > 0 && txbPassword.Text == txbConfirm.Text)
                {
                    bool exist = false;
                    foreach (User user in Data.Instance.UsersList) if (user.Email == txbEmail.Text.Trim()) exist = true;
                    if (exist) throw null;

                    int _ID = UserBLL.Instance.RetreiveUserID();
                    string _UserName = txbUserName.Text;
                    var h1 = new DTO.Hash();
                    string _Password = h1.MD5(txbPassword.Text);
                    string _Email = txbEmail.Text;
                    string _Role = cbBoxRole.Text;

                    if(UserBLL.Instance.AddNewUser(new User() { ID = _ID, Name = _UserName, Role = _Role, Email = _Email, Password = _Password })) MessageBox.Show("Them Thanh Cong!");
                    else MessageBox.Show("Them That Bai!");
                }
                else throw null;
            }
            catch
            {
                MessageBox.Show("Loi Nhap Thong Tin!");
            }
        }

    }
}
