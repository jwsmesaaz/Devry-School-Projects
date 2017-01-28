using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            //This declares the variable for Annual Hours and sets it to what the user enters
            double dblAnnualHours = Convert.ToDouble(txtAnnualHours.Text);
            //This declares the variable for Rate and sets it to what the user enters
            double dblRate = Convert.ToDouble(lblRate.Text);
            //This declares the variable for salary based on the multiplication of Annual Hours and Rate
            double dblSalary = dblAnnualHours * dblRate;
            //Changes the label for the salary to be the calculation of annual hours and rate.
            lblSalary.Text = "$ " + dblSalary.ToString();
        }
    }
}