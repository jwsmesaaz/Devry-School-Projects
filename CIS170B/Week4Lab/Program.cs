using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSmithWeek2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Declare constants
            //Note that all constants have a capital letter for better visiblity in program.

            //Federal Income Tax constant
            const Double dblFedIncomeTax = .28;
            //Social Security Tax constant
            const Double dblSocialTax = .0765;
            //What overtime pay is more than regular hourly pay.
            const Double dblOvertimePay = 1.5;
            //Program Version
            const String stringVersion = "4.0";

            //Declare Variables
            //Note that all variables have a lower case letter for better visibility in the program.

            //Employee's Full Name
            string stringFullName = "";
            //Regular Hours
            double dblRegHours = 0;
            //Employee's Overtime hours
            double dblOvertimeHours = 0;
            //Employee's Hourly Pay
            double dblRegHourPay = 0;
            //Employee's Gross Pay
            double dblGrossPay = 0;
            //Employee's Social Security Tax Withholding
            double dblSocialWithhold = 0;
            //Employee's Federal Tax withholding
            double dblFedWithhold = 0;
            //Employee's Net Pay after taxes are removed
            double dblNetPay = 0;

            //Call on Methods

            DisplayTitle(stringVersion);
            GetPayInput(ref stringFullName, ref dblRegHours, ref dblOvertimeHours, ref dblRegHourPay);
            PayCalcs(dblOvertimePay, dblSocialTax, dblFedIncomeTax, ref dblNetPay, ref dblFedWithhold, ref dblSocialWithhold, ref dblRegHours, ref dblRegHourPay, ref dblOvertimeHours, ref dblGrossPay);
            DisplayPayrollInformation(dblGrossPay, dblFedWithhold, dblSocialWithhold, dblNetPay);
            DisplayClose(stringVersion);


        }
        //Methods

        //Display title and welcome to program.
        static void DisplayTitle(String stringVersion)
        {
            Console.WriteLine("Thank you for using Pay Calculator " + stringVersion + ".");
        }

        //Method for getting input
        static void GetPayInput(ref string stringFullName, ref double dblRegHours, ref double dblOvertimeHours, ref double dblRegHourPay)
        {
            //Getting employee Name.
            stringFullName = GetName();
            //Getting hours employee worked.
            dblRegHours = GetRegHrs();
            //Using the "dblRegHours" to get the overtime hours if any.
            dblOvertimeHours = GetOtHours(dblRegHours);
            //Getting the hourly pay rate.
            dblRegHourPay = GetRate();
        }
        //Methods inside of GetPay Input
        static string GetName()
        {
            //Employee's Name
            string stringName;
            Console.WriteLine("Please enter the employee's full name. ");
            stringName = Console.ReadLine();
            return stringName;
        }
        static double GetRegHrs()
        {
            //Regular hours that the employee Worked
            double dblHours;
            Console.WriteLine("Please enter the amount of hours the employee worked. ");
            dblHours = Convert.ToDouble(Console.ReadLine());
            return dblHours;
        }
        static double GetOtHours(double dblRegHours)
        {
            //Overtime hours that the employee Worked
            Double dblOtHours = 0;
            if (dblRegHours > 40)
            {
                dblOtHours = (dblRegHours - 40);
            }
            return dblOtHours;
        }
        static double GetRate()
        {
            Double dblRate;
            //Get Employee's Regular Pay
            Console.WriteLine("Please enter the pay the employee recieves every hour. ");
            dblRate = Convert.ToDouble(Console.ReadLine());
            return dblRate;
        }
        
        //Method for calculating pay of employee
        static void PayCalcs(Double dblOvertimePay, Double dblSocialTax, Double dblFedIncomeTax, ref double dblNetPay, ref double dblFedWithhold, ref double dblSocialWithhold, ref double dblRegHours, ref double dblRegHourPay, ref double dblOvertimeHours, ref double dblGrossPay)
        {
            //Calls on the methods that calculates Gross Pay, Federal Withholding, Social Security Withholding, and The net Pay for employee.
            dblGrossPay = CalcGross(dblOvertimePay, dblRegHours, dblRegHourPay, dblOvertimeHours);
            dblFedWithhold = CalcFedTax(dblFedIncomeTax, dblGrossPay);
            dblSocialWithhold = CalcSSTax(dblSocialTax, dblGrossPay);
            dblNetPay = CalcNet(dblGrossPay, dblSocialWithhold, dblFedWithhold);
        }
        //Methods insode PayCalcs
        static double CalcGross(Double dblOvertimePay, double dblRegHours, double dblRegHourPay, double dblOvertimeHours)
        {
            //Calculates the gross pay.
            double dblGrossPay;
            //if employee gets overtime it will calculate this else the gross pay is calculated.
            if (dblRegHours > 40)
            {
                dblRegHours = (dblRegHours - dblOvertimeHours);
                dblGrossPay = ((dblRegHours * dblRegHourPay) + (dblOvertimeHours * dblOvertimePay * dblRegHourPay));
            }
            else
            {
                dblGrossPay = (dblRegHours * dblRegHourPay);
            }
            return dblGrossPay;
        }
        static double CalcFedTax(Double dblFedIncomeTax, double dblGrossPay)
        {
            //Calculate the Employee's Federal Withholding
            Double dblFedWithhold;
            dblFedWithhold = (dblFedIncomeTax * dblGrossPay);
            return dblFedWithhold;
        }
        static double CalcSSTax(Double dblSocialTax, double dblGrossPay)
        {
            //Calculate the Employee's Social Security Withholding
            double dblSocialWithhold;
            dblSocialWithhold = (dblSocialTax * dblGrossPay);
            return dblSocialWithhold;
        }
        static double CalcNet(double dblGrossPay, double dblSocialWithhold, double dblFedWithhold)
        {

            //Calculate the Employee's Net Pay
            double dblNetPay;
            dblNetPay = (dblGrossPay - dblSocialWithhold - dblFedWithhold);
            return dblNetPay;
        }
        
        //Method for displaying payroll information
        static void DisplayPayrollInformation(double dblGrossPay, double dblFedWithhold, double dblSocialWithhold, double dblNetPay)
        {
            //Display the Results from the pay calculator.

            Console.WriteLine("Weekly payroll information summery for ");
            ;
            Console.WriteLine("Gross Pay: {0:C}", dblGrossPay);
            Console.WriteLine("Federal income tax withheld: {0:C}", dblFedWithhold);
            Console.WriteLine("Social Security taxes withheld: {0:C}", dblSocialWithhold);
            Console.WriteLine("Net pay: {0:C}", dblNetPay);
        }
        
        //Method for displaying closing message
        static void DisplayClose(string stringVersion)
        {
            Console.WriteLine("Thank you for using Pay Calculator " + stringVersion + ".");
        }
    }

}
