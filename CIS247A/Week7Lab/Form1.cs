using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmithWk7Lab
{
    public partial class fmEmployeePayrollSystem : Form
    {      
        fmEmployeeForm ef;
        int intLogInTrys;
        //instantiate object from current form
        fmEmployeePayrollSystem eps;
        public fmEmployeePayrollSystem()
        {
            InitializeComponent();
        }        

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text.Trim() == "J")
            {
                if (txtPassword.Text.Trim() == "1")
                {
                    eps = new fmEmployeePayrollSystem();

                    //hide current form
                    eps.Close();

                    //Instantiate new form
                    ef = new fmEmployeeForm();


                    //show new form
                    ef.Show();
                }
                else
                {
                    intLogInTrys++;
                    MessageBox.Show("Incorrect password please try again", "Invalid Password", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("That is not a valid user name", "Invalid User Name", MessageBoxButtons.OK);
                intLogInTrys++;
            }
            if (intLogInTrys > 3)
            {
                MessageBox.Show("Please contact administrator for the correct user name and password.", "Too Many Trys",MessageBoxButtons.OK);
                Application.Exit();
            }
            
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
