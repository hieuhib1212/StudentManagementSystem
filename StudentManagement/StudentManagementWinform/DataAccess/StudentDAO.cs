using StudentManagementWinform.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentManagementWinform.DataAccess
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return instance; }
            set => instance = value;
        }
        public DataTable SearchStudent(string StudentID)
        {
            string query = "SELECT * FROM Student WHERE StudentID LIKE '%" + StudentID + "%'";
            return DAO.Instance.GetDataBySQL(query);
        }
        public DataTable getAllStudent()
        {
            string query = @"SELECT * FROM Student";
            return DAO.Instance.GetDataBySQL(query);
        }
        public bool Login(string username, string password)
        {
            string querry = "SELECT * FROM [Student] WHERE StudentLogin='" + username + "' AND StudentPassword='" + password + "'";
            DataTable result = DAO.Instance.GetDataBySQL(querry);
            return result.Rows.Count > 0;
        }
        public int UpdatePassword(string StudentID, string NewPassword)
        {
            string query = "UPDATE Student SET StudentPassword=@Password \n" +
                "WHERE StudentID=@ID";
            List<SqlParameter> values = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@ID", SqlDbType.NVarChar);
            param1.Value = StudentID;
            values.Add(param1);
            SqlParameter param2 = new SqlParameter("@Password", SqlDbType.NVarChar);
            param2.Value = NewPassword;
            values.Add(param2);
            int row = DAO.Instance.ExecuteSQL(query, values.ToArray<SqlParameter>());
            return row;
        }
        public int UpdateStudent(Student student)
        {
            string query = "UPDATE Student SET StudentName=@Name, StudentGender=@Gender, StudentDOB=@DOB, StudentEmail=@Email \n" +
                "WHERE StudentID=@ID";
            List<SqlParameter> values = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@ID", SqlDbType.NVarChar);
            param1.Value = student.StudentID;
            values.Add(param1);
            SqlParameter param2 = new SqlParameter("@Name", SqlDbType.NVarChar);
            param2.Value = student.StudentName;
            values.Add(param2);
            SqlParameter param3 = new SqlParameter("@Gender", SqlDbType.Bit);
            param3.Value = student.StudentGender;
            values.Add(param3);
            SqlParameter param4 = new SqlParameter("@DOB", SqlDbType.DateTime);
            param4.Value = student.StudentDOB;
            values.Add(param4);
            SqlParameter param5 = new SqlParameter("@Email", SqlDbType.NVarChar);
            param5.Value = student.StudentEmail;
            values.Add(param5);
            int row = DAO.Instance.ExecuteSQL(query, values.ToArray<SqlParameter>());
            return row;
        }
        public int InsertStudent(Student student)
        {
            string query = "INSERT INTO [Student](StudentID, StudentName, StudentGender, StudentDOB, StudentEmail, StudentLogin, StudentPassword) VALUES(@ID, @Name, @Gender, @DOB, @Email, @Login, @Password)";
            List<SqlParameter> values = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@ID", SqlDbType.NVarChar);
            param1.Value = student.StudentID;
            values.Add(param1);
            SqlParameter param2 = new SqlParameter("@Name", SqlDbType.NVarChar);
            param2.Value = student.StudentName;
            values.Add(param2);
            SqlParameter param3 = new SqlParameter("@Gender", SqlDbType.Bit);
            param3.Value = student.StudentGender;
            values.Add(param3);
            SqlParameter param4 = new SqlParameter("@DOB", SqlDbType.DateTime);
            param4.Value = student.StudentDOB;
            values.Add(param4);
            SqlParameter param5 = new SqlParameter("@Email", SqlDbType.NVarChar);
            param5.Value = student.StudentEmail;
            values.Add(param5);
            SqlParameter param6 = new SqlParameter("@Login", SqlDbType.NVarChar);
            param6.Value = student.StudentLogin;
            values.Add(param6);
            SqlParameter param7 = new SqlParameter("@Password", SqlDbType.NVarChar);
            param7.Value = student.StudentPassword;
            values.Add(param7);
            int row = DAO.Instance.ExecuteSQL(query, values.ToArray<SqlParameter>());
            return row;
        }
        public Student getStudentByID(string ID)
        {
            Student std = new Student();
            string query = @"SELECT * FROM Student WHERE StudentID=@ID";
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.NVarChar);
                    command.Parameters["@ID"].Value = ID;
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DataRow dr = table.Rows[0];
                        std = new Student(dr["StudentID"].ToString(),
                            dr["StudentName"].ToString(),
                            Convert.ToBoolean(dr["StudentGender"]),
                            Convert.ToDateTime(dr["StudentDOB"]),
                            dr["StudentEmail"].ToString());
                    }catch(Exception e)
                    {

                    }finally
                    {
                        connection.Close();
                    }
                }
            }
            return std;

        }
        public Student getStudentByLogin(string Login)
        {
            Student std = new Student();
            string query = @"SELECT * FROM Student WHERE StudentLogin=@Login";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Login", SqlDbType.NVarChar);
                    command.Parameters["@Login"].Value = Login;
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        DataRow dr = table.Rows[0];
                        std = new Student(dr["StudentID"].ToString(),
                            dr["StudentName"].ToString(),
                            Convert.ToBoolean(dr["StudentGender"]),
                            Convert.ToDateTime(dr["StudentDOB"]),
                            dr["StudentEmail"].ToString(),
                            dr["StudentLogin"].ToString(),
                            dr["StudentPassword"].ToString());
                    }
                    catch (Exception e)
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return std;

        }
    }
}
