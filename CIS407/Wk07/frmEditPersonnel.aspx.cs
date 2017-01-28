using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creates an entry into the database for this page when the user lands on it.
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmEditPersonnel");
        }
    }
}