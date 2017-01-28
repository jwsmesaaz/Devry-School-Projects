using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk3Lab
{
    class PayCheck
    {
        //Declare Constants

        private const Double dblFedTax = .28;
        private const Double dblSocialTax = .0765;

        //Declare Variables

        private double dblHourlyPay;
        private double dblHoursWorked;
        private double dblGrossPay;
        private double dblNetPay;
        private double dblFedTaxWithheld;
        private double dblSocialTaxWithheld;

        //Constructor

        public PayCheck() { }

        //Overloaded Constructor

        public PayCheck(double dblHourlyPay, double dblHoursWorked, double dblGrossPay, double dblNetPay, double dblFedTaxWithheld, double dblSocialTaxWithheld)
        {
            this.dblHourlyPay = dblHourlyPay;
            this.dblHoursWorked = dblHoursWorked;
            this.dblGrossPay = dblGrossPay;
            this.dblNetPay = dblNetPay;
            this.dblFedTaxWithheld = dblFedTaxWithheld;
            this.dblSocialTaxWithheld = dblSocialTaxWithheld;
        }

        //Get/set methods

        public double HourlyPay
        {
            get { return dblHourlyPay; }

            set { dblHourlyPay = value; }
        }
        public double HoursWorked
        {
            get { return dblHoursWorked; }

            set { dblHoursWorked = value; }
        }
        public double GrossPay
        {
            get { return dblGrossPay; }

            set { dblGrossPay = value; }
        }
        public double NetPay
        {
            get { return dblNetPay; }

            set { dblNetPay = value; }
        }
        public double FedTaxWithheld
        {
            get { return dblFedTaxWithheld; }

            set { dblFedTaxWithheld = value; }
        }
        public double SocialTaxWithheld
        {
            get { return dblSocialTaxWithheld; }

            set { dblSocialTaxWithheld = value; }
        }

        //Deconstructor

        ~PayCheck() { }

        //Methods for finding Net Pay and both Federal and Social Taxes

        public double GetFederalWithheld()
        {
            double dblFederalTaxWithheld;

            dblFederalTaxWithheld = (dblGrossPay * dblFedTax);

            return dblFederalTaxWithheld;
        }
        public double GetSocialWithheld()
        {
            double dblSocialTaxWithheld;

            dblSocialTaxWithheld = (dblGrossPay * dblSocialTax);

            return dblSocialTaxWithheld;
        }
        public double GetNetPay()
        {
            double dblNetPay;

            dblNetPay = (dblGrossPay - (dblSocialTaxWithheld + dblFedTaxWithheld));

            return dblNetPay;
        }

        public double GetFederalWithheld(double dblGrossPay)
        {
            double dblFederalTaxWithheld;

            dblFederalTaxWithheld = (dblGrossPay * dblFedTax);

            return dblFederalTaxWithheld;
        }
        public double GetSocialWithheld(double dblGrossPay)
        {
            double dblSocialTaxWithheld;

            dblSocialTaxWithheld = (dblGrossPay * dblSocialTax);

            return dblSocialTaxWithheld;
        }
        public double GetNetPay(double dblGrossPay, double dblSocialTaxWithheld, double dblFedTaxWithheld)
        {
            double dblNetPay;

            dblNetPay = (dblGrossPay - (dblSocialTaxWithheld + dblFedTaxWithheld));

            return dblNetPay;
        }

        //Display Paycheck Method

        public void DisplayPaycheck()
        {
            Console.WriteLine("Employee's Hourly Pay           {0:c}", dblHourlyPay);
            Console.WriteLine("Employee's Hours Worked         {0:c}", dblHoursWorked);
            Console.WriteLine("Employee's Gross Pay            {0:c}", dblGrossPay);
            Console.WriteLine("Employee's Federaal Withholding {0:c}", dblFedTaxWithheld);
            Console.WriteLine("Employee's Social Withholding   {0:c}", dblSocialTaxWithheld);
            Console.WriteLine("Employee's Net Pay              {0:c}", dblNetPay);            
        }


    }
}
