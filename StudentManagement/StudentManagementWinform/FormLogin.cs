using StudentManagementWinform.DataAccess;
using StudentManagementWinform.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagementWinform
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginName = Username.Text;
            string loginPassword = Password.Text;
            if (Login(loginName, loginPassword))
            {
                FormManagement fstd = new FormManagement(AccountDAO.Instance.getID(loginName));
                Hide();
                fstd.ShowDialog();
                Show();
            }else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            
        }
        bool Login(string loginName, string loginPassword)
        {
            return AccountDAO.Instance.Login(loginName, loginPassword);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }
    }
}
