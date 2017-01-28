using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Writes information into the text box
            txtVerifiedInfo.Text = Request["txtFirstName"] +
                //Return then Last Name
                "\n" + Request["txtLastName"] +
                //Return then Pay Rate
                "\n" + Request["txtPayRate"] +
                //Return then Start Date
                "\n" + Request["txtStartDate"] +
                //Return then End Date
                "\n" + Request["txtEndDate"];
        }
    }
}