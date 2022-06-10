using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StudentManagementWinform.DataAccess
{
    class SubjectDAO
    {
        private static SubjectDAO instance;

        internal static SubjectDAO Instance
        {
            get { if (instance == null) instance = new SubjectDAO(); return instance; }
            set => instance = value;
        }
        public int InsertSubject(Subject subject)
        {
            string query = "INSERT INTO [Subject] VALUES(@ID, @Name)";
            List<SqlParameter> values = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@ID", SqlDbType.NVarChar);
            param1.Value = subject.SubjectID;
            values.Add(param1);
            SqlParameter param2 = new SqlParameter("@Name", SqlDbType.NVarChar);
            param2.Value = subject.SubjectName;
            values.Add(param2);
            int row = DAO.Instance.ExecuteSQL(query, values.ToArray<SqlParameter>());
            return row;
        }
        public int DeleteSubject(string ID)
        {
            string query = "DELETE FROM [Subject] WHERE SubjectID=@ID";
            SqlParameter param = new SqlParameter("@ID", SqlDbType.NVarChar);
            param.Value = ID;
            return DAO.Instance.ExecuteSQL(query, param);
        }
        public DataTable GetCurrentStudentsSubject(string ID)
        {
            string query = "SELECT * FROM [Subject] O RIGHT JOIN StudentSubjectStatus P ON O.SubjectID = P.SubjectID \n" +
                "WHERE StudentID=" + "'" + ID + "'" ;
            return DAO.Instance.GetDataBySQL(query);
        }
        public DataTable GetAllSubject()
        {
            string query = "SELECT * FROM [Subject]";
            return DAO.Instance.GetDataBySQL(query);
        }
        public int UpdateChange(Subject subject)
        {
            string query = "UPDATE [Subject] SET SubjectName=@NewName WHERE SubjectID=@ID";
            List<SqlParameter> values = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@ID", SqlDbType.NVarChar);
            param1.Value = subject.SubjectID;
            values.Add(param1);
            SqlParameter param2 = new SqlParameter("@NewName", SqlDbType.NVarChar);
            param2.Value = subject.SubjectName;
            values.Add(param2);
            int row = DAO.Instance.ExecuteSQL(query, values.ToArray<SqlParameter>());
            return row;
        }
        public DataTable GetSubjectByStudentID(string StudentID)
        {
            string query = "SELECT * FROM [Subject] WHERE StudentID='"+ StudentID +"'";
            return DAO.Instance.GetDataBySQL(query);
        }
        public int ShowSubjectStatus(string StudentID, string SubjectID )
        {
            int status = -1;
            string query = "SELECT SubjectStatus FROM StudentSubjectStatus WHERE StudentID=@StudentID AND SubjectID=@SubjectID";
            using (SqlConnection conn = DAO.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar);
                cmd.Parameters["@StudentID"].Value = StudentID;
                cmd.Parameters.Add("@SubjectID", SqlDbType.NVarChar);
                cmd.Parameters["@SubjectID"].Value = SubjectID;
                try
                {
                    conn.Open();
                    status = (int) cmd.ExecuteScalar();
                    
                }catch(Exception e)
                {

                }finally
                {
                    conn.Close();
                }
            }
            return status;
        }
    }
}
