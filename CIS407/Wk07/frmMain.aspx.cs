using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creates an entry into the database for this page when the user lands on it.
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmMain");

            //Displays buttons or doesn't depending on the session
            if (Session["SecurityLevel"] == "Admin")
            {
                //Displays buttons
                linkbtnNewEmployee.Visible = true;
                linkbtnViewUserActivity.Visible = true;
                linkbtnEditEmployees.Visible = true;
                linkbtnManageUser.Visible = true;
            }
            else
            {
                //Hides buttons
                linkbtnNewEmployee.Visible = false;
                linkbtnViewUserActivity.Visible = false;
                linkbtnEditEmployees.Visible = false;
                linkbtnManageUser.Visible = false;
                DoubleLine01.Visible = false;
                DoubleLine03.Visible = false;
            }
        }
    }
}