using StudentManagementWinform.DataAccess;
using System;
using System.Windows.Forms;

namespace StudentManagementWinform
{
    public partial class FormAdmin : Form
    {
        private int ID;
        public FormAdmin(int id)
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (RetypeBox.Text.Equals(PasswordBox.Text))
            {
                int i = 0;
                i = AccountDAO.Instance.Update(ID, LoginNameBox.Text, PasswordBox.Text);
                if (i > 0)
                {
                    MessageBox.Show("Thay Đổi Thông Tin Thành Công", "Thông Báo");
                }else
                {
                    MessageBox.Show("Thông Tin Đã Tồn Tại", "Thông báo");
                }


            }else
            { 
                MessageBox.Show("Vui Lòng Nhập Lại Mật Khẩu", "Thông báo");

            }
            
            
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
