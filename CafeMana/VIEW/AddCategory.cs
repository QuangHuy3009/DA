using CafeMana.DTO;
using CafeMana.BLL;
using System;
using System.IO;
using System.Windows.Forms;

namespace CafeMana.VIEW
{
    public partial class AddCategory : Form
    {

        public AddCategory()
        {
            InitializeComponent();
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
                CategoryPictureBox.Load(ofd.FileName);

        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                MemoryStream ms = new MemoryStream();
                CategoryPictureBox.Image.Save(ms, CategoryPictureBox.Image.RawFormat);

                int    _ID          = CategoryBLL.Instance.RetreiveCategoryID();
                string _Name        = CategoryNameBox.Text;
                string _Description = CategoryDescriptionRBox.Text;
                byte[] _Image       = ms.GetBuffer();
              
                Category category = new Category() { ID = _ID, Name = _Name, Description = _Description, Image = _Image};
                CategoryBLL.Instance.AddNewCategory(category);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
