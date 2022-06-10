using StudentManagementWinform.DataAccess;
using StudentManagementWinform.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentManagementWinform
{
    public partial class StudentAdd : Form
    {
        public StudentAdd()
        {
            InitializeComponent();
            DOBPicker.CustomFormat = "dd/MM/yyyy";
            DOBPicker.Format = DateTimePickerFormat.Custom;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(StudentIDBox.Text.Trim().Equals("") 
                || StudentNameBox.Text.Trim().Equals("")
                || StudentEmailBox.Text.Trim().Equals("") 
                || StudentLogin.Text.Trim().Equals("") 
                || StudentPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Thông Báo");
            }else
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9]+@[a-zA-Z]{3,5}\.[a-zA-Z]{3,3}$");
                if (!regex.IsMatch(StudentEmailBox.Text))
                {
                    MessageBox.Show("Địa Chỉ Email không hợp lệ", "Thông Báo");
                    return;
                }
                Student student = new Student(StudentIDBox.Text, StudentNameBox.Text, Male.Checked ? true : false, DOBPicker.Value, StudentEmailBox.Text, StudentLogin.Text, StudentPassword.Text);
                int confirm = StudentDAO.Instance.InsertStudent(student);
                if (confirm > 0)
                {
                    MessageBox.Show("Thêm Sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Thêm Sinh viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Reset()
        {
            StudentIDBox.Text = "";
            StudentNameBox.Text = "";
            StudentEmailBox.Text = "";
            StudentLogin.Text = "";
            StudentPassword.Text = "";
            DOBPicker.Value = DateTime.Now;
            Male.Checked = true;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AddButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateBttn_Click(object sender, EventArgs e)
        {
            var passwordBuilder = new StringBuilder();
            passwordBuilder.Append(RandomString(4, true));
            passwordBuilder.Append(RandomNumber(1000, 9999));
            passwordBuilder.Append(RandomString(2));
            StudentPassword.Text = passwordBuilder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
 
        public string RandomString(int size, bool lowerCase = false)
        {
            Random r = new Random();
            var builder = new StringBuilder(size);  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var @char = (char)r.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            Male.Checked = true;
        }

    }
}
