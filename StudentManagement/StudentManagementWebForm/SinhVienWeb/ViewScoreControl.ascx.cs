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
    public partial class ViewScoreControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student student = (Student)Session["StdInfo"];
            ScoreGV.DataSource = SubjectStatusList.GetSubjectStatus(student.StudentID);
            ScoreGV.DataBind();

        }
    }
}