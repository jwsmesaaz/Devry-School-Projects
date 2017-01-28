using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk7Lab
{
    public class Payroll
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

        public Payroll() { }

        //Overloaded Constructor

        public Payroll(double dblHourlyPay, double dblHoursWorked, double dblGrossPay, double dblNetPay, double dblFedTaxWithheld, double dblSocialTaxWithheld)
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

        //Get methods
        public double GrossPay
        {
            get { return dblGrossPay; }
        }
        public double NetPay
        {
            get { return dblNetPay; }
        }
        public double FedTaxWithheld
        {
            get { return dblFedTaxWithheld; }
        }
        public double SocialTaxWithheld
        {
            get { return dblSocialTaxWithheld; }
        }

        //Deconstructor

        ~Payroll() { }

        //Methods for finding Gross and Net Pay along with both Federal and Social Taxes

        public double GetFederalWithheld()
        {
            double dblGrossPay;
            double dblOvertime;
            double dblHourWorked;

            if (dblHoursWorked < 40)
            {
                dblOvertime = 0;
                dblHourWorked = dblHoursWorked;
            }
            else
            {
                dblOvertime = dblHoursWorked - 40;
                dblHourWorked = dblHoursWorked - dblHoursWorked;
            }
            dblGrossPay = ((dblHourWorked * dblHourlyPay) + (dblHourlyPay * 1.5 * dblOvertime));

            double dblFederalTaxWithheld;

            dblFederalTaxWithheld = (dblGrossPay * dblFedTax);

            return dblFederalTaxWithheld;
        }
        public double GetSocialWithheld()
        {
            double dblGrossPay;
            double dblOvertime;
            double dblHourWorked;

            if (dblHoursWorked < 40)
            {
                dblOvertime = 0;
                dblHourWorked = dblHoursWorked;
            }
            else
            {
                dblOvertime = dblHoursWorked - 40;
                dblHourWorked = dblHoursWorked - dblHoursWorked;
            }
            dblGrossPay = ((dblHourWorked * dblHourlyPay) + (dblHourlyPay * 1.5 * dblOvertime));

            double dblSocialTaxWithheld;

            dblSocialTaxWithheld = (dblGrossPay * dblSocialTax);

            return dblSocialTaxWithheld;
        }
        public double GetNetPay()
        {
            double dblGrossPay;
            double dblOvertime;
            double dblHourWorked;
            double dblFederalTaxWithheld;
            double dblSocialTaxWithheld;
            
            if (dblHoursWorked < 40)
            {
                dblOvertime = 0;
                dblHourWorked = dblHoursWorked;
            }
            else
            {
                dblOvertime = dblHoursWorked - 40;
                dblHourWorked = dblHoursWorked - dblHoursWorked;
            }
            dblGrossPay = ((dblHourWorked * dblHourlyPay) + (dblHourlyPay * 1.5 * dblOvertime));
            dblFederalTaxWithheld = (dblGrossPay * dblFedTax);
            dblSocialTaxWithheld = (dblGrossPay * dblSocialTax);

            double dblNetPay;

            dblNetPay = (dblGrossPay - (dblSocialTaxWithheld + dblFedTaxWithheld));

            return dblNetPay;
        }
        public double GetGrossPay()
        {
            double dblGrossPay;
            double dblOvertime;
            double dblHourWorked;

            if (dblHoursWorked < 40)
            {
                dblOvertime = 0;
                dblHourWorked = dblHoursWorked;
            }
            else
            {
                dblOvertime = dblHoursWorked - 40;
                dblHourWorked = dblHoursWorked - dblHoursWorked;
            }
            dblGrossPay = ((dblHourWorked * dblHourlyPay) + (dblHourlyPay * 1.5 * dblOvertime));

            return dblGrossPay;
        }



    }
}
