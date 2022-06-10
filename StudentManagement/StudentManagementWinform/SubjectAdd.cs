using StudentManagementWinform.DataAccess;
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
    public partial class SubjectAdd : Form
    {
        public SubjectAdd()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (SubjectIDBox.Text != null && SubjectNameBox.Text != null)
            {
                Subject sub = new Subject(SubjectIDBox.Text, SubjectNameBox.Text);
                int row = SubjectDAO.Instance.InsertSubject(sub);
                if (row > 0)
                {
                    MessageBox.Show("Nhập thông tin thành công", "Thông Báo");
                    Close();
                }else
                {
                    MessageBox.Show("Trùng Thông tin môn học", "Thông Báo");
                }
            }else
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo");
            }
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SubjectIDBox.Text = "";
            SubjectNameBox.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
