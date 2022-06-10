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
    public partial class SubjectModify : Form
    {
        public SubjectModify()
        {
            InitializeComponent();
        }

        private void SubjectModify_Load(object sender, EventArgs e)
        {
            SubjectTable.AutoGenerateColumns = false;
            SubjectTable.Columns.Add("ID", "Mã Môn");
            SubjectTable.Columns["ID"].DataPropertyName = "SubjectID";
            SubjectTable.Columns.Add("Name", "Tên Môn Học");
            SubjectTable.Columns["Name"].DataPropertyName = "SubjectName";
            //
            DataGridViewButtonColumn DelBttn = new DataGridViewButtonColumn();
            DelBttn.Name = "Detail";
            DelBttn.HeaderText = "";
            DelBttn.Text = "Chi Tiết";
            DelBttn.UseColumnTextForButtonValue = true;
            SubjectTable.Columns.Add(DelBttn);
            LoadSubject();
        }
        private void LoadSubject()
        {
            SubjectTable.RowHeadersVisible = false;
            SubjectTable.DataSource = SubjectList.GetSubjectList();
        }
        private void ChooseSubject(int RowIndex)
        {
            SubjectIDBox.Text = SubjectTable.Rows[RowIndex].Cells["ID"].Value.ToString();
            SubjectNameBox.Text = SubjectTable.Rows[RowIndex].Cells["Name"].Value.ToString();
            
        }
        private void SubjectTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(SubjectTable[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell )
            {
                ChooseSubject(e.RowIndex);
            }
        }
        private void DeleteSubject(string ID)
        {
            
        }

        private void ApplyChangeBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Áp dụng thay đổi", "Xác Nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int RowCount = SubjectDAO.Instance.UpdateChange(new Subject(SubjectIDBox.Text, SubjectNameBox.Text));
                if(RowCount > 0)
                {
                    MessageBox.Show("Thay đổi Thành công", "Thông Báo");
                }else
                {
                    MessageBox.Show("Thay đổi thất bại", "Thông Báo");
                }
            }
        }
    }
}
