using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class frmPersonnelVerified : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Writes information into the text box
            txtVerifiedInfo.Text = Session["txtFirstName"].ToString() +
                //Return then Last Name
                "\n" + Session["txtLastName"].ToString() +
                //Return then Pay Rate
                "\n" + Session["txtPayRate"].ToString() +
                //Return then Start Date
                "\n" + Session["txtStartDate"].ToString() +
                //Return then End Date
                "\n" + Session["txtEndDate"].ToString();
        }
    }
}