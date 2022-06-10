using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementWinform.DataAccess
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance { 
            get {if (instance == null) instance = new AccountDAO();return instance; }
            set => instance = value; 
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string querry = "SELECT * FROM [Admin] WHERE AdminLogin='"+ username+"' AND AdminPassword='"+password+"'";
            DataTable result = DAO.Instance.GetDataBySQL(querry);
            return result.Rows.Count > 0;
        }
        public int getID(string username)
        {
            int ID = -1;
            using(SqlConnection conn = DAO.Instance.GetConnection()) {
                string query = "SELECT AdminID FROM [Admin] WHERE AdminLogin=@Login";
                using(SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.Add("@Login", SqlDbType.NVarChar);
                    command.Parameters["@Login"].Value = username;
                    conn.Open();
                    ID = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return ID;
        }
        public int Update(int ID, string adminName, string password)
        {
            string query = "UPDATE [Admin] SET AdminLogin=@Login, AdminPassword=@Password WHERE AdminID=@ID";
            List<SqlParameter> values = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@Login", SqlDbType.NVarChar);
            param1.Value = adminName;
            values.Add(param1);
            SqlParameter param2 = new SqlParameter("@Password", SqlDbType.NVarChar);
            param2.Value = password;
            values.Add(param2);
            SqlParameter param3 = new SqlParameter("@ID", SqlDbType.Int);
            param3.Value = ID;
            values.Add(param3);
            int row = DAO.Instance.ExecuteSQL(query, values.ToArray());
            return row;
        }
    }
}
