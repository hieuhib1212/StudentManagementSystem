using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementWinform.DataAccess
{
    public class DAO
    {
        private static DAO instance;
        

        public static DAO Instance { 
            get { if (instance == null) instance = new DAO(); return DAO.instance; } 
            private set => instance = value; 
        }


        static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


        public SqlConnection GetConnection()
        {

            return new SqlConnection(ConnectionString);
        }
        public DataTable GetDataBySQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            DataTable ds = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            return ds;
        }
        public int ExecuteSQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
        

    }
}
