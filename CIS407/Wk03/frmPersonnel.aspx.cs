using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class frmPersonnel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creates an entry into the database for this page when the user lands on it.
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //initializes and declares variable as true to start to see if everything checks out in the code
            bool blnAllWhite = true;
            //initializes and declares the first day variable
            DateTime myFirstDay = DateTime.Parse(txtStartDate.Text);
            //initializes and declares the end date variable
            DateTime andImFired = DateTime.Parse(txtEndDate.Text);

            //sets the session warning message as nothing before begining
            Session["warningMessage"] = "";
            //sets the session error count to 0 before beginning
            Session["errorNumbers"] = 0;
            //Finds out about the Start and End date being blank first so that they 

            //If Statment to find out if the End Date field is good or not
            if (txtEndDate.Text == "" || txtEndDate.Text == null)
            {
                //Sets Background color to Yellow                
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                //Adds to the warning message
                setWarningMessage("Well it is good to keep employees around you need to fire this one then put in an end date");
                //Tells the boolean that not everything is alright
                blnAllWhite = false;
                //Sets Label to needing to be fixed
                lblEndDate.ForeColor = System.Drawing.Color.Red;
                //Puts the curser in the box if this is blank
                txtEndDate.Focus();
            }
            else
            {
                //Sets Background color to White                
                txtEndDate.BackColor = System.Drawing.Color.White;
                //Resets label if everything is good
                lblEndDate.ForeColor = System.Drawing.Color.Black;
            }
            
            //If Statment to find out if the Start Date field is good or not
            if (txtStartDate.Text == "" || txtStartDate.Text == null)
            {
                //Sets Background color to Yellow                
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                //Adds to the warning message
                setWarningMessage("An employee without a start date are you mad");
                //Tells the boolean that not everything is alright
                blnAllWhite = false;
                //Sets Label to needing to be fixed
                lblStartDate.ForeColor = System.Drawing.Color.Red;
                //Puts the curser in the box if this is blank
                txtStartDate.Focus();
            }
            else
            {
                //Sets Background color to White                
                txtStartDate.BackColor = System.Drawing.Color.White;
                //Resets label if everything is good
                lblStartDate.ForeColor = System.Drawing.Color.Black;
            }

            //Makes sure that there is something in both the start and end dates
            if (blnAllWhite == true)
            {
                //Decided to use a case statement since there was more then an if else statment and what was returned were three numbers
                switch (DateTime.Compare(myFirstDay, andImFired))
                {
                    case 0:
                        //This happens when the dates are the same which isn't allowed

                        //This sets the warning message so you are able to give a list of items that need to be fixed
                        setWarningMessage("Start and end date are the same and must be different");
                        //Changes the background color of Start Date to Yellow
                        txtStartDate.BackColor = System.Drawing.Color.Yellow;
                        //Changes the background color of the End Date to Yellow
                        txtEndDate.BackColor = System.Drawing.Color.Yellow;
                        //Tells the boolean that not everything is alright
                        blnAllWhite = false;
                        //Puts the curser in the box if End date isn't greater then start date
                        txtStartDate.Focus();
                        //Sets Label to needing to be fixed
                        lblStartDate.ForeColor = System.Drawing.Color.Red;
                        //Sets Label to needing to be fixed
                        lblEndDate.ForeColor = System.Drawing.Color.Red;
                        break;
                    case 1:
                        //This happens if the start date is greater than the end date which can't happen

                        //This sets the warning message so you are able to give a list of items that need to be fixed
                        setWarningMessage("You can't be fired before starting");
                        //Changes the background color of Start Date to Yellow
                        txtStartDate.BackColor = System.Drawing.Color.Yellow;
                        //Changes the background color of the End Date to Yellow
                        txtEndDate.BackColor = System.Drawing.Color.Yellow;
                        //Tells the boolean that not everything is alright
                        blnAllWhite = false;
                        //Puts the curser in the box if End date isn't greater then start date
                        txtStartDate.Focus();
                        //Sets Label to needing to be fixed
                        lblStartDate.ForeColor = System.Drawing.Color.Red;
                        //Sets Label to needing to be fixed
                        lblEndDate.ForeColor = System.Drawing.Color.Red;
                        break;
                    case -1:
                        //This is the only valid option

                        //Changes the background color of Start Date to White
                        txtStartDate.BackColor = System.Drawing.Color.White;
                        //Changes the background color of the End Date to White
                        txtEndDate.BackColor = System.Drawing.Color.White;
                        //Resets labels if everything is good
                        lblStartDate.ForeColor = System.Drawing.Color.Black;
                        //Resets labels if everything is good
                        lblEndDate.ForeColor = System.Drawing.Color.Black;
                        break;
                }
            }

            //If Statment to find out if the Pay Rate field is good or not
            if (txtPayRate.Text == "" || txtPayRate.Text == null)
            {
                //Sets Background color to Yellow                
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                //Adds to the warning message
                setWarningMessage("People Don't work for free. Pay them something");
                //Tells the boolean that not everything is alright
                blnAllWhite = false;
                //Sets Label to needing to be fixed
                lblPayRate.ForeColor = System.Drawing.Color.Red;
                //Puts the curser in the box if this is blank
                txtPayRate.Focus();
            }
            else
            {
                //Sets Background color to White                
                txtPayRate.BackColor = System.Drawing.Color.White;
                //Resets label if everything is good
                lblPayRate.ForeColor = System.Drawing.Color.Black;
            }

            //If Statment to find out if the Last Name field is good or not
            if (txtLastName.Text == "" || txtLastName.Text == null)
            {
                //Sets Background color to Yellow                
                txtLastName.BackColor = System.Drawing.Color.Yellow;
                //I got a little carried away with the warning messages
                if (txtFirstName.Text == "" || txtFirstName.Text == null)
                {
                    //Adds to the warning message
                    setWarningMessage("Hmmm no first or last name. Maybe you should have just put Doe for last name");
                }
                else
                {
                    //Adds to the warning message
                    setWarningMessage(txtFirstName.Text + " who? Maybe you should enter the last name to go with the first");
                }
                //Tells the boolean that not everything is alright
                blnAllWhite = false;
                //Sets Label to needing to be fixed
                lblLastName.ForeColor = System.Drawing.Color.Red;
                //Puts the curser in the box if this is blank
                txtLastName.Focus();
            }
            else
            {
                //Sets Background color to White                
                txtLastName.BackColor = System.Drawing.Color.White;
                //Resets label if everything is good
                lblLastName.ForeColor = System.Drawing.Color.Black;
            }

            //If Statment to find out if the First name field is good or not
            if (txtFirstName.Text == "" || txtFirstName.Text == null)
            {
                //Sets Background color to Yellow                
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                //Adds to the warning message
                setWarningMessage("What are you not on a first name basis or did you just forget");
                //Tells the boolean that not everything is alright
                blnAllWhite = false;
                //Sets Label to needing to be fixed
                lblFirstName.ForeColor = System.Drawing.Color.Red;
                //Puts the curser in the box if this is blank
                txtFirstName.Focus();
            }
            else
            {
                //Sets Background color to White                
                txtFirstName.BackColor = System.Drawing.Color.White;
                //Resets label if everything is good
                lblFirstName.ForeColor = System.Drawing.Color.Black;
            }     

            //If Statement to make decide if the person is going to stay on this page or go to another
            if (blnAllWhite == false)
            {
                //Writes to error to the user everything else works as it should
                lblError.Text = "You have " + Session["errorNumbers"] + " errors to resolve before continuing. Please resolve the following to continue:" +
                    "\n" + Session["warningMessage"].ToString();
            }
            else
            {
                Session["txtFirstName"] = txtFirstName.Text;
                Session["txtLastName"] = txtLastName.Text;
                Session["txtPayRate"] = txtPayRate.Text;
                Session["txtStartDate"] = txtStartDate.Text;
                Session["txtEndDate"] = txtEndDate.Text;
                Response.Redirect("~/frmPersonnelVerified.aspx");
            }
        }
        private void setWarningMessage(string strWarningMessage)
        {
            //Increases the error message counter
            Session["errorNumbers"] = Convert.ToInt32(Session["errorNumbers"]) + 1;
            //If statement to create warning message
            if (Session["warningMessage"] == null || Session["warningMessage"] == String.Empty)
            {
                //Message that will write the first message
                Session["warningMessage"] = strWarningMessage;                
            }
            else
            {
                //Message that will write any additional errors
                Session["warningMessage"] = Session["warningMessage"] + 
                "\n" + strWarningMessage;
            }
        }
    }
}