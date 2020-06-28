using System;
using CafeMana.DTO;
using CafeMana.BLL;
using System.Windows.Forms;

namespace CafeMana.VIEW
{
    public partial class fAccountProfile : Form
    {
        public fAccountProfile()
        {
            InitializeComponent();
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            User user = Data.Instance.User;
            txbUserName.Text = user.Name;
            txbEmail.Text    = user.Email;
            txbConfirm.Text  = txbNewPass.Text = txbPassword.Text = user.Password;
            txbRole.Text     = user.Role;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure!", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txbUserName.Text.Trim().Length > 0 && txbPassword.Text.Trim().Length > 0 && txbEmail.Text.Trim().Length > 0  && txbNewPass.Text == txbConfirm.Text)
                {
                    int _ID          = Data.Instance.User.ID;
                    string _UserName = txbUserName.Text;
                    var h1 = new DTO.Hash();
                    string _Password = h1.MD5(txbNewPass.Text);
                    string _Email    = txbEmail.Text;
                    string _Role     = txbRole.Text;

                    UserBLL.Instance.UpdateUser(new User() { ID = _ID, Name = _UserName, Role = _Role, Email = _Email, Password = _Password });
                    MessageBox.Show("Successfully!");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
        }
    }

         
}
