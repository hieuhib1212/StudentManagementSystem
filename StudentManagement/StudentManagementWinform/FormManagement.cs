using StudentManagementWinform.DataAccess;
using StudentManagementWinform.Logic;
using System;
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
    public partial class FormManagement : Form
    {
        private int ID;
        public FormManagement(int id)
        {
            InitializeComponent();
            DOBPicker.CustomFormat = "dd/MM/yyyy";
            DOBPicker.Format = DateTimePickerFormat.Custom;
            ID = id;
        }
        private void LoadStudentsTable()
        {
            StudentTable.AutoGenerateColumns = false;
            StudentTable.Columns.Add("ID", "MSSV");
            StudentTable.Columns["ID"].DataPropertyName = "StudentID";
            StudentTable.Columns.Add("Name", "Họ và Tên");
            StudentTable.Columns["Name"].DataPropertyName = "StudentName";
            StudentTable.Columns.Add("DOB", "Ngày Sinh");
            StudentTable.Columns["DOB"].DataPropertyName = "StudentDOB";
            StudentTable.Columns.Add("Gender", "Giới Tính");
            StudentTable.Columns["Gender"].DataPropertyName = "StudentGenderString";

            StudentTable.Columns.Add("Email", "Địa chỉ email");
            StudentTable.Columns["Email"].DataPropertyName = "StudentEmail";
            //
            DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
            detail.Name = "Detail";
            detail.HeaderText = "";
            detail.Text = "Chi Tiết";
            detail.UseColumnTextForButtonValue = true;
            StudentTable.Columns.Add(detail);
            List<Student> list = StudentList.GetStudentList();
            list.Sort(new SortByName());
            StudentTable.DataSource = list;

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            StudentTable.Columns.Add(dgvCmb);
        }
        private void LoadSubjectTable()
        {
            SubjectTable.AutoGenerateColumns = false;
            SubjectTable.Columns.Add("ID", "Mã môn học");
            SubjectTable.Columns["ID"].DataPropertyName = "SubjectID";
            SubjectTable.Columns.Add("Name", "Tên môn học");
            SubjectTable.Columns["Name"].DataPropertyName = "SubjectName";
            DataGridViewButtonColumn detail = new DataGridViewButtonColumn();
            detail.Name = "Detail";
            detail.HeaderText = "";
            detail.Text = "Chi Tiết";
            detail.UseColumnTextForButtonValue = true;
            SubjectTable.Columns.Add(detail);
            

        }
        private void FormManagement_Load(object sender, EventArgs e)
        {
            StudentTable.RowHeadersVisible = false;
            SubjectTable.RowHeadersVisible = false;
            LoadStudentsTable();
            LoadSubjectTable();

        }

        private void StudentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(StudentTable.CurrentCell is DataGridViewCheckBoxCell)
            {
                if(StudentTable.CurrentCell.Value is true)
                {
                    StudentTable.CurrentCell.Value = false;
                }else
                {
                    StudentTable.CurrentCell.Value = true;
                }
                
            }
            if (StudentTable.CurrentCell is DataGridViewButtonCell)
            {
                string ID = StudentTable.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                StudentDetail(ID);
            }else
            {
                DataGridViewRow CurRow = StudentTable.Rows[StudentTable.CurrentCell.RowIndex];
                string StudentID = CurRow.Cells["ID"].Value.ToString();
                SubjectTable.DataSource = SubjectDAO.Instance.GetCurrentStudentsSubject(StudentID);
            }
        }
        private void StudentDetail(string StudentID)
        {
            Student std = StudentDAO.Instance.getStudentByID(StudentID);
            StudentIDBox.Text = std.StudentID;
            StudentNameBox.Text = std.StudentName;
            DOBPicker.Value = new DateTime(std.StudentDOB.Year, std.StudentDOB.Month, std.StudentDOB.Day);
            StudentEmailBox.Text = std.StudentEmail;
            if (std.StudentGender)
            {
                Male.Checked = true;
                Female.Checked = false;
            }
            else
            {
                Male.Checked = false;
                Female.Checked = true;
            }
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubjectAdd SForm = new SubjectAdd();
            SForm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Đăng Xuất Khỏi Ứng Dụng", "Thông Báo", MessageBoxButtons.YesNo))
            {
                Close();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chỉnhSửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubjectModify MForm = new SubjectModify();
            MForm.ShowDialog();
        }

        private void ModifyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(ModifyCheck.Checked == true)
            {
                DOBPicker.Enabled = true;
                StudentNameBox.ReadOnly = false;
                Male.AutoCheck = true;
                Female.AutoCheck = true;
                StudentEmailBox.ReadOnly = false;
                ModifyBttn.Enabled = true;
            }else
            {
                DOBPicker.Enabled = false;
                StudentNameBox.ReadOnly = true;
                Male.AutoCheck = false;
                Female.AutoCheck = false;
                StudentEmailBox.ReadOnly = true;
                ModifyBttn.Enabled = false;
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin fadmin = new FormAdmin(ID);
            fadmin.ShowDialog();
        }

        private void ModifyBttn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+@[a-zA-Z]{3,5}\.[a-zA-Z]{3,3}$");
            
            if (StudentIDBox.Text.Equals(""))
            {
                MessageBox.Show("Chọn Sinh Viên", "Thông Báo");
                return;
            }
            if (!regex.IsMatch(StudentEmailBox.Text))
            {
                MessageBox.Show("Địa Chỉ Email không hợp lệ", "Thông Báo");
                return;
            }
            bool gender = true;
            if(!Male.Checked)
            {
                gender = false;
            }
            Student student = new Student(StudentIDBox.Text, StudentNameBox.Text, gender, DOBPicker.Value, StudentEmailBox.Text);
            StudentDAO.Instance.UpdateStudent(student);
            StudentTable.DataSource = StudentList.GetStudentList();
        }

        private void SubjectTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SubjectTable.Columns[SubjectTable.CurrentCell.ColumnIndex].Name.Equals("Detail"))
            {
                int row = StudentTable.CurrentCell.RowIndex;
                string SubjectID = SubjectTable.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string SubjectName = SubjectTable.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                
                string StudentID = StudentTable.Rows[row].Cells["ID"].Value.ToString();
                string StudentName = StudentDAO.Instance.getStudentByID(StudentID).StudentName;
                int status = SubjectDAO.Instance.ShowSubjectStatus(StudentID, SubjectID);
                string StatusString = string.Empty;
                switch(status)
                {
                    case 0:
                        StatusString = "In Progress";
                        break;
                    case 1:
                        StatusString = "Not Passed";
                        break;
                    case 2:
                        StatusString = "Passed";
                        break;
                    default:
                        break;
                }
                string info = "Họ và Tên: " + StudentName + "\n" +
                    "Mã số Sinh Viên: " + StudentID + "\n" +
                    "Mã Môn học: " + SubjectID + "\n" +
                    "Trạng Thái: " + StatusString;
                MessageBox.Show(info, "Thông tin chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddStudentBttn_Click(object sender, EventArgs e)
        {
            StudentAdd saform = new StudentAdd();
            saform.ShowDialog();
            StudentTable.DataSource = StudentList.GetStudentList();
        }


        private void NameRadBttn_CheckedChanged(object sender, EventArgs e)
        {
            List<Student> list = StudentList.GetStudentList();
            if (NameRadBttn.Checked)
            {
                list.Sort(new SortByName());
                StudentTable.DataSource = list;
            }else
            {
                list.Sort(new SortByID());
                StudentTable.DataSource = list;
            }
        }

        private void SearchBttn_Click(object sender, EventArgs e)
        {
            StudentTable.DataSource = StudentListSearch.GetStudentList(SearchBox.Text);
        }

        private void StudentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
