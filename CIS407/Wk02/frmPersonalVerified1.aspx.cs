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
            //txtVerifiedInfo.Text = Request["txtFirstName"] +
                //Return then Last Name
            //    "\n" + Request["txtLastName"] +
                //Return then Pay Rate
           //     "\n" + Request["txtPayRate"] +
                //Return then Start Date
           //     "\n" + Request["txtStartDate"] +
                //Return then End Date
            //    "\n" + Request["txtEndDate"];
            //Declares the value for the string getting passed over
            string strVerifyInfo;

            //Setting the value for the declared string
            strVerifyInfo = PreviousPage.FindControl(txtFirstName);
            //txtVerifiedInfo.Text = Request["txtFirstName"];
            //    "\n" + Request["txtLastName"] +
            //    "\n" + Request["txtPayRate"] +
            //    "\n" + Request["txtStartDate"] +
            //    "\n" + Request["txtEndDate"];

            //Writes the information into the text box
            txtVerifiedInfo.Text = strVerifyInfo;
        }
    }
}