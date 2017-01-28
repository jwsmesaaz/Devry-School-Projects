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
    public partial class fmEmployeeForm : Form
    {
        OfficeManager offman;
        public fmEmployeeForm()
        {
            InitializeComponent();
        }

        private void fmEmployeeForm_Load(object sender, EventArgs e)
        {
            offman = new OfficeManager();
        }

        private void btnProcessEmployee_Click(object sender, EventArgs e)
        {
            if ((txtCity.Text.Trim() != "") && (txtStreet.Text.Trim() != "") && (txtFirstName.Text.Trim() != "") && (txtLastName.Text.Trim() != "") && (mtxtSocialSecurityNumber.Text.Trim() != "") && (mtxtTelephoneNumber.Text.Trim() != "") && (mtxtZip.Text.Trim() != "") && (cbState.Text.Trim() != "") && (dtpHireDate.Text.Trim() != "Monday, January 01, 1753") && (cbKnowsPasswords.Text.Trim() != "") && (cbHasAPhone.Text.Trim() != ""))
            {
                if (Convert.ToDouble(mtxtHourlyPay.Text.Trim()) == 0)
                {
                    MessageBox.Show("You must enter all information before pressing process employee.", "Mission information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (Convert.ToDouble(mtxtHoursWorked.Text.Trim()) == 0)
                {
                    MessageBox.Show("You must enter all information before pressing process employee.", "Mission information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if((cbPhoneLines.Text.Trim() == "Yes") || (cbPhoneLines.Text.Trim() == "No"))
                {
                    MessageBox.Show("4You must enter all information before pressing process employee.", "Mission information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //Unhideing Show Paycheck button

                    btnShowPaycheck.Visible = true;

                    //Hiding the Process Employee button

                    btnProcessEmployee.Visible = false;

                    //Changeing yes and not to boolean then inputing data into proper variables

                    if (cbKnowsPasswords.Text.Trim() == "Yes")
                    {
                        offman.KnowsPasswords = true;
                    }
                    else if (cbKnowsPasswords.Text.Trim() == "No")
                    {
                        offman.KnowsPasswords = false;
                    }
                    else
                    {
                        MessageBox.Show("Error with program please contact technical support for help.", "Boolean error 101", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    if (cbHasAPhone.Text.Trim() == "Yes")
                    {
                        offman.HasPhone = true;
                    }
                    else if (cbHasAPhone.Text.Trim() == "No")
                    {
                        offman.HasPhone = false;
                    }
                    else
                    {
                        MessageBox.Show("Error with program please contact technical support for help.", "Boolean error 101", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    //Inputing information from user into variables

                    offman.FirstName = txtFirstName.Text.Trim();
                    offman.LastName = txtLastName.Text.Trim();
                    offman.SocialSecurity = mtxtSocialSecurityNumber.Text.Trim();
                    offman.PhoneNumber = mtxtTelephoneNumber.Text.Trim();
                    offman.AddressStreet = txtStreet.Text.Trim();
                    offman.AddressCity = txtCity.Text.Trim();
                    offman.AddressState = cbState.Text.Trim();
                    offman.AddressZip = txtStreet.Text.Trim();
                    offman.ThePayroll.HourlyPay = Convert.ToDouble(mtxtHourlyPay.Text.Trim());
                    offman.ThePayroll.HoursWorked = Convert.ToDouble(mtxtHoursWorked.Text.Trim());
                    offman.HireDate = Convert.ToDateTime(dtpHireDate.Text.Trim());
                    offman.NumberOfLines = Convert.ToInt32(cbPhoneLines.Text.Trim());

                    //Setting all text boxes to read only

                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    mtxtSocialSecurityNumber.ReadOnly = true;
                    mtxtTelephoneNumber.ReadOnly = true;
                    txtStreet.ReadOnly = true;
                    txtCity.ReadOnly = true;
                    cbState.Visible = false;
                    mtxtZip.ReadOnly = true;
                    mtxtHourlyPay.ReadOnly = true;
                    mtxtHoursWorked.ReadOnly = true;
                    dtpHireDate.Visible = false;
                    cbKnowsPasswords.Visible = false;
                    cbHasAPhone.Visible = false;
                    cbPhoneLines.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("You must enter all information before pressing process employee.", "Mission information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cbHasAPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhoneLines.Visible = true;
        }

        private void btnShowPaycheck_Click(object sender, EventArgs e)
        {     
            //Figuring out the gross pay of the employee

            txtGrossPay.Text = Convert.ToString(offman.ThePayroll.GetGrossPay());
            

            //Figuring out the Federal and Social Security tax for the employee

            txtFedTaxWithheld.Text = Convert.ToString(offman.ThePayroll.GetFederalWithheld());
            txtSocialTaxWithheld.Text = Convert.ToString(offman.ThePayroll.GetSocialWithheld());

            //Figuring out the Net Pay of employee

            txtNetPay.Text = Convert.ToString(offman.ThePayroll.GetNetPay());

            //hiding Show Paycheck button

            btnShowPaycheck.Visible = false;

            //UnHiding the Process Employee button

            btnProcessEmployee.Visible = true;

            //Making all the other information visable again

            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            mtxtSocialSecurityNumber.ReadOnly = false;
            mtxtTelephoneNumber.ReadOnly = false;
            txtStreet.ReadOnly = false;
            txtCity.ReadOnly = false;
            cbState.Visible = true;
            mtxtZip.ReadOnly = false;
            mtxtHourlyPay.ReadOnly = false;
            mtxtHoursWorked.ReadOnly = false;
            dtpHireDate.Visible = true;
            cbKnowsPasswords.Visible = true;
            cbHasAPhone.Visible = true;
            cbPhoneLines.Visible = true;

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {       
            //Reseting what is hidden and what is visable.

            //hiding Show Paycheck button

            btnShowPaycheck.Visible = false;

            //UnHiding the Process Employee button

            btnProcessEmployee.Visible = true;

            //Making all the other information visable again

            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            mtxtSocialSecurityNumber.ReadOnly = false;
            mtxtTelephoneNumber.ReadOnly = false;
            txtStreet.ReadOnly = false;
            txtCity.ReadOnly = false;
            cbState.Visible = true;
            mtxtZip.ReadOnly = false;
            mtxtHourlyPay.ReadOnly = false;
            mtxtHoursWorked.ReadOnly = false;
            dtpHireDate.Visible = true;
            cbKnowsPasswords.Visible = true;
            cbHasAPhone.Visible = true;
            cbPhoneLines.Visible = false;
            

            //Reset values in text boxes.

            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            mtxtSocialSecurityNumber.Text = " ";
            mtxtTelephoneNumber.Text = " ";
            txtStreet.Text = " ";
            txtCity.Text = " ";
            cbState.Text = " ";
            mtxtZip.Text = " ";
            mtxtHourlyPay.Text = " ";
            mtxtHoursWorked.Text = " ";
            dtpHireDate.Text = "Monday, January 01, 1753";
            cbKnowsPasswords.Text = " ";
            cbHasAPhone.Text = " ";
            cbPhoneLines.Text = " ";
            txtGrossPay.Text = " ";
            txtNetPay.Text = " ";
            txtFedTaxWithheld.Text = " ";
            txtSocialTaxWithheld.Text = " ";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
