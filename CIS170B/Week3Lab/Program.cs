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
            //Program Version
            const string stringVersion = "3.0";

            //Declare constants

            //Federal Income Tax constant
            const Double dblFedIncomeTax = .28;
            //Social Security Tax constant
            const Double dblSocialTax = .0765;

            //Declare Variables

            //Employee's Full Name
            string stringFullName;
            //Regular Hours
            Double dblRegHours = 0;
            //Employee's Overtime hours
            Double dblOvertimeHours = 0;
            //Employee's Hourly Pay
            Double dblRegHourPay = 0;
            //Employee's Gross Pay
            Double dblGrossPay = 0;
            //Employee's Social Security Tax Withholding
            Double dblSocialWithhold = 0;
            //Employee's Federal Tax withholding
            Double dblFedWithhold = 0;
            //Employee's Net Pay after taxes are removed
            Double dblNetPay = 0;

            //Call on Methods

            DisplayTitle(stringVersion);
            stringFullName = GetName();
            dblRegHours = GetRegHrs();
            dblOvertimeHours = GetOtHours();
            dblRegHourPay = GetRate();
            dblGrossPay = CalcGross(dblRegHours, dblRegHourPay, dblOvertimeHours, dblRegHourPay);
            dblFedWithhold = CalcFedTax(dblFedIncomeTax, dblGrossPay);
            dblSocialWithhold = CalcSSTax(dblSocialTax, dblGrossPay);
            dblNetPay = CalcNet(dblGrossPay, dblSocialWithhold, dblFedWithhold);
            DisplayPayrollInformation(dblGrossPay, dblFedWithhold, dblSocialWithhold, dblNetPay);
            DisplayClose(stringVersion);


        }

        static double CalcGross(double dblRegHours, double dblRegHourPay, double dblOvertimeHours, double dblRegHourPay_4)
        {
            Double dblGrossPay;
            dblGrossPay = ((dblRegHours * dblRegHourPay) + (dblOvertimeHours * 1.5 * dblRegHourPay));
            return dblGrossPay;
        }
        static void DisplayTitle(string stringVersion)
        {
            Console.WriteLine("Thank you for using Pay Calculator " + stringVersion + ".");
        }
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
        static double GetOtHours()
        {
            //Overtime hours that the employee Worked
            Double dblOtHours;
            Console.WriteLine("Please enter the amount of overtime hours the employee worked. ");
            dblOtHours = Convert.ToDouble(Console.ReadLine());
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
        static double CalcGross(Double dblRegHours, Double dblRegHourPay, Double dblOvertimeHours)
        {
            //Calculate the Employee's Gross Pay
            Double dblGrossPay;
            dblGrossPay = (dblRegHours * dblRegHourPay + dblOvertimeHours * 1.5 * dblRegHourPay);
            return dblGrossPay;
        }
        static double CalcFedTax(Double dblFedIncomeTax, Double dblGrossPay)
        {
            //Calculate the Employee's Federal Withholding
            Double dblFedWithhold;
            dblFedWithhold = (dblFedIncomeTax * dblGrossPay);
            return dblFedWithhold;
        }
        static double CalcSSTax(Double dblSocialTax, Double dblGrossPay)
        {
            //Calculate the Employee's Social Security Withholding
            Double dblSocialWithhold;
            dblSocialWithhold = (dblSocialTax * dblGrossPay);
            return dblSocialWithhold;
        }
        static double CalcNet(Double dblGrossPay, Double dblSocialWithhold, Double dblFedWithhold)
        {

            //Calculate the Employee's Net Pay
            Double dblNetPay;
            dblNetPay = (dblGrossPay - dblSocialWithhold - dblFedWithhold);
            return dblNetPay;
        }
        static void DisplayPayrollInformation(Double dblGrossPay, Double dblFedWithhold, Double dblSocialWithhold, Double dblNetPay)
        {
            //Display the Results from the pay calculator.

            Console.WriteLine("Weekly payroll information summery for ");
            ;
            Console.WriteLine("Gross Pay: {0:C}", dblGrossPay);
            Console.WriteLine("Federal income tax withheld: {0:C}", dblFedWithhold);
            Console.WriteLine("Social Security taxes withheld: {0:C}", dblSocialWithhold);
            Console.WriteLine("Net pay: {0:C}", dblNetPay);
        }
        static void DisplayClose(string stringVersion)
        {
            Console.WriteLine("Thank you for using Pay Calculator " + stringVersion + ".");
        }
    }

}
