
using StudentManagementWinform.DataAccess;
using StudentManagementWinform.Logic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBttn_Click(object sender, EventArgs e)
        {
            if(LoginControl())
            {
                Session["UserName"] = StudentLogin.Text;
                Session["Password"] = StudentPassword.Text;
                Student student = StudentDAO.Instance.getStudentByLogin(StudentLogin.Text);
                Session["StdInfo"] = student;
                Response.Redirect("StudentPage.aspx");
                
                
                
            }else
            {
                Response.Redirect("Login.aspx");
            }
        }
        private bool LoginControl()
        {

            myConnection.Open();

            string query = "SELECT * FROM [Student] WHERE StudentLogin=@Login AND StudentPassword=@Password";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("@Login", StudentLogin.Text);
            command.Parameters.AddWithValue("@Password", StudentPassword.Text);
            DataTable ds = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            myConnection.Close();
            return ds.Rows.Count > 0;
        }
        
            
        
    }
}