using StudentManagementWinform.DataAccess;
using StudentManagementWinform.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementWebForm.SinhVienWeb
{
    public partial class StudentInfoControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student student = (Student)Session["StdInfo"];
            StudentID.Text = student.StudentID;
            StudentName.Text = student.StudentName;
            StudentDOB.Text = student.StudentDOB.ToString("dd/MM/yyyy");
            Gender.Text = student.StudentGender ? "Nam" : "Nữ";
            Email.Text = student.StudentEmail;
            
        }

        protected void ChangePW_Click(object sender, EventArgs e)
        {
            Student student = (Student)Session["StdInfo"];
            if(student.StudentPassword.Equals(OldPassword.Text) && NewPassword.Text.Equals(RenewPassword.Text))
            {
                int row = StudentDAO.Instance.UpdatePassword(student.StudentID, NewPassword.Text);
                if(row > 0)
                {
                    Notify.ForeColor = System.Drawing.Color.Blue;
                    Notify.Text = "Thay Đổi Thành Công";
                }else
                {
                    Notify.ForeColor = System.Drawing.Color.Red;
                    Notify.Text = "Thay Đổi Thất Bại";
                }
            }
        }
    }
}