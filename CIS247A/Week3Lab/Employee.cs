using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk3Lab
{
    class Employee
    {
        //Set Variables

        private string strFirstName;
        private string strLastName;
        private string strSocialNumber;
        private string strAddress;
        private string strCity;
        private string strState;
        private string strZip;
        private double dblHourlyPay;
        private double dblHoursWorked;
        private double dblOvertime;
        private double dblNetPay;

        //Declare objects (Job and Paycheck)

        private PayCheck pc;
        private Job job;

        //Constructor

        public Employee() 
        {
            //instantiate object of Paycheck and Job class

            pc = new PayCheck();
            job = new Job();
        }

        //Overload Constructor

        public Employee(string strFirstName, string strLastName, string strSocialNumber, string strAddress, string strCity, string strState, string strZip, double dblHourlyPay, double dblHoursWorked)
        {
            this.strFirstName = strFirstName;
            this.strLastName = strLastName;
            this.strSocialNumber = strSocialNumber;
            this.strAddress = strAddress;
            this.strCity = strCity;
            this.strState = strState;
            this.strZip = strZip;
            this.dblHoursWorked = dblHoursWorked;
            this.dblHourlyPay = dblHourlyPay;

            //instantiate object of Paycheck and Job class

            pc = new PayCheck();
            job = new Job();
        }

        //Accessor/Mutator Methods for all variables

        public PayCheck ThePayCheck
        {
            get { return pc; }
            set { pc = value; }
        }
        public Job TheJob
        {
            get { return job; }
            set { job = value; }
        }

        public string FirstName
        {
            get { return strFirstName; }

            set { strFirstName = value; }
        }
        public string LastName
        {
            get { return strLastName; }

            set { strLastName = value; }
        }
        public string SocialNumber
        {
            get { return strSocialNumber; }

            set { strSocialNumber = value; }
        }
        public string Address
        {
            get { return strAddress; }

            set { strAddress = value; }
        }
        public string City
        {
            get { return strCity; }

            set { strCity = value; }
        }
        public string State
        {
            get { return strState; }

            set { strState = value; }
        }
        public string Zip
        {
            get { return strZip; }

            set { strZip = value; }
        }
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
        public double Overtime
        {
            get { return dblOvertime; }

            set { dblOvertime = value; }
        }
        public double NetPay
        {
            get { return dblNetPay; }

            set { dblNetPay = value; }
        }
        
        //Deconstructor

        ~Employee() { }

        //Two Methods


        public double GetOvertime()
        {
            double dblOvertime;

            if (dblHoursWorked > 40)
            {
                dblOvertime = (dblHoursWorked - 40);
            }
            else
            {
                dblOvertime = 0;
            }

            return dblOvertime;
        }

        public double Pay()
        {
            double dblPay;

            dblPay = (((dblHoursWorked - dblOvertime) * (dblHourlyPay)) + ((dblOvertime) * (dblHourlyPay * 1.5)));

            return dblPay;
        }

        //Method for displaying Information

        public void DisplayInformation()
        {
            Console.WriteLine("Employee's First Name             " + strFirstName);
            Console.WriteLine("Employee's Last Name              " + strLastName);
            Console.WriteLine("Employee's Social Security Number " + strSocialNumber);
            Console.WriteLine("Employee's Address                " + strAddress);
            Console.WriteLine("Employee's City                   " + strCity);
            Console.WriteLine("Employee's State                  " + strState);
            Console.WriteLine("Employee's Zip Code               " + strZip);
            Console.WriteLine("Employee's Hours Worked           " + dblHoursWorked);
            Console.WriteLine("Employee's Hourly Pay             {0:c}", dblHourlyPay);
            Console.WriteLine("Employee's Net Pay                {0:c}", dblNetPay);
        }


    }
}
