using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmithWk6Lab
{
    public partial class Form1 : Form
    {
        public Form1(string stringVersion)
        {
            InitializeComponent();
        }

        private void btnCalcWages_Click(object sender, EventArgs e)
        {
            double dblRegHours;
            double dblRegHourPay;
            bool boolTrueNum = false;
            while (boolTrueNum == false)
            {
                try
                {
                    dblRegHours = double.Parse(txtTotalHours.Text.Trim());
                    boolTrueNum = true;
                }
                catch (FormatException a)
                {
                    MessageBox.Show("Please enter Hours");
                    
                }

                try
                {
                    dblRegHourPay = double.Parse(txtHourlyWage.Text.Trim());
                    boolTrueNum = true;
                }
                catch (FormatException b)
                {
                    MessageBox.Show("Please enter Wages");
                    
                }
                
            }

            //Declare constants

            //Federal Income Tax constant
            Double dblFedIncomeTax = .28;
            //Social Security Tax constant
            Double dblSocialTax = .0765;

            //Declare Variables

            //Employee's Full Name
            string stringFullName = txtEmployeeName.Text.Trim();
            //Regular Hours
            dblRegHours = Convert.ToDouble(txtTotalHours.Text.Trim());            
            //Employee's Hourly Pay
            dblRegHourPay = Convert.ToDouble(txtHourlyWage.Text.Trim());
            //Employee's Gross Pay
            double dblGrossPay = 0;
            //Employee's Social Security Tax Withholding
            double dblSocialWithhold = 0;
            //Employee's Federal Tax withholding
            double dblFedWithhold = 0;
            //Employee's Net Pay after taxes are removed
            double dblNetPay = 0;
            //Overtime earned
            double dblOvertimeHours = 0;

                            
                     
            CalcPay(ref dblOvertimeHours, ref dblSocialTax, ref dblFedIncomeTax, ref dblNetPay, ref dblFedWithhold, ref dblSocialWithhold, ref dblRegHours, ref dblRegHourPay, ref dblGrossPay);

            txtGrossWages.Text = Convert.ToString(dblGrossPay);
            txtFedTax.Text = Convert.ToString(dblFedWithhold);
            txtSSTax.Text = Convert.ToString(dblSocialWithhold);
            txtNetPay.Text = Convert.ToString(dblNetPay);
                       
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            //Clear the Input areas to allow for more information to be input.
            txtEmployeeName.Clear();
            txtTotalHours.Clear();
            txtHourlyWage.Clear();
            txtGrossWages.Clear();
            txtFedTax.Clear();
            txtSSTax.Clear();
            txtNetPay.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {                       
            Application.Exit();
        }
        static void CalcPay(ref double dblOvertimeHours, ref Double dblSocialTax, ref Double dblFedIncomeTax, ref double dblNetPay, ref double dblFedWithhold, ref double dblSocialWithhold, ref double dblRegHours, ref double dblRegHourPay, ref double dblGrossPay)
        {
            CalcOvertime(ref dblRegHours, ref dblOvertimeHours);
            //Calculate gross pay, federal and social taxes, and the net pay.

            //Calculate gross pay
            dblGrossPay = ((dblRegHours * dblRegHourPay) + (dblOvertimeHours * 1.5 * dblRegHourPay));            
            //Calculate the Employee's Federal Withholding
            dblFedWithhold = (dblFedIncomeTax * dblGrossPay);
            //Calculate the Employee's Social Security Withholding
            dblSocialWithhold = (dblSocialTax * dblGrossPay);
            //Calculate the Employee's Net Pay
            dblNetPay = (dblGrossPay - (dblSocialWithhold + dblFedWithhold));
        }
        static void CalcOvertime(ref double dblRegHours, ref double dblOvertimeHours)
        {
            if (dblRegHours > 40)
            {
                dblOvertimeHours = (dblRegHours - 40);
                dblRegHours = (dblRegHours - dblOvertimeHours);
            }
            else
            {
                dblOvertimeHours = 0;
            }
        }
      

        
        //Method for displaying closing message
        static void DisplayClose(string stringVersion)
        {
            MessageBox.Show("Thank you for using Pay Calculator " + stringVersion + ".");
        }
    }
}

