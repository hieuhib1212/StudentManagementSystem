using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace StudentManagementWebForm
{
    public class LoginDAO
    {
        private static LoginDAO instance;

        internal static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; }
            set
            {
                instance = value;
            }
        }
        private LoginDAO() { }
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM [Admin] WHERE AdminLogin='" + username + "' AND AdminPassword='" + password + "'";
            DataTable result = DAO.Instance.GetDataBySQL(query);
            return result.Rows.Count > 0;
        }
    }
}