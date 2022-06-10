using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementWebForm
{
    public partial class ViewScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentName.Text = Session["UserName"].ToString();
        }
    }
}