using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagementWinform.Logic
{
    public class Admin
    {
        public string loginname { get; set; }
        public string password { get; set; }

        public Admin(string loginname, string password)
        {
            this.loginname = loginname;
            this.password = password;
        }

        public Admin()
        {
        }
    }
}
