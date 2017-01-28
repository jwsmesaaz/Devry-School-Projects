using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //Clears the first name field
            txtFirstName.Text = "";
            //Clears the Last name field
            txtLastName.Text = "";
            //Clears the PayRate field
            txtPayRate.Text = "";
            //Clears the STart Date field
            txtStartDate.Text = "";
            //Clears the End Date Fiels
            txtEndDate.Text = "";
        }
    }
}