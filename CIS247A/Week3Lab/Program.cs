using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk3Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            string strFirstName;
            string strLastName;
            string strSocialNumber;
            string strAddress;
            string strCity;
            string strState;
            string strZip;
            double dblHourlyPay;
            double dblHoursWorked;
            double dblGrossPay;
            double dblNetPay;
            double dblFedTaxWithheld;
            double dblSocialTaxWithheld;
            string strJobName;
            string strMainJobDuty;
            double dblJobHours;

            Employee emp = new Employee();
            PayCheck pc = new PayCheck();
            Job job = new Job();

            //Constructor information from user.

            Console.WriteLine("Please enter employee's First Name. ");
            emp.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter employee's Last Name. ");
            emp.LastName = Console.ReadLine();
            Console.WriteLine("Please enter employee's Social Security Number. ");
            emp.SocialNumber = Console.ReadLine();
            Console.WriteLine("Please enter employee's Address. ");
            emp.Address = Console.ReadLine();
            Console.WriteLine("Please enter employee's city of residance. ");
            emp.City = Console.ReadLine();
            Console.WriteLine("Please enter employee's state of residance. ");
            emp.State = Console.ReadLine();
            Console.WriteLine("Please enter employee's zip code. ");
            emp.Zip = Console.ReadLine();
            Console.WriteLine("Please enter employee's hourly pay. ");
            double dblTemp = Convert.ToDouble(Console.ReadLine());
            emp.HourlyPay = dblTemp;
            pc.HourlyPay = dblTemp;            
            Console.WriteLine("Please enter hours the employee worked. ");
            dblTemp = Convert.ToDouble(Console.ReadLine());
            emp.HoursWorked = dblTemp;
            pc.HoursWorked = dblTemp;
            emp.Overtime = emp.GetOvertime();
            emp.NetPay = emp.Pay();
            pc.GrossPay = emp.Pay();
            pc.SocialTaxWithheld = pc.GetSocialWithheld();
            pc.FedTaxWithheld = pc.GetFederalWithheld();
            pc.NetPay = pc.GetNetPay();
            Console.WriteLine("Please enter job name. ");
            strJobName = Console.ReadLine();
            Console.WriteLine("Please enter the main job duty. ");
            strMainJobDuty = Console.ReadLine();
            Console.WriteLine("Please enter hours for job. ");
            dblJobHours = Convert.ToDouble(Console.ReadLine());

            //Displaying the input from the constructor

            emp.DisplayInformation();
            Console.ReadLine();
            pc.DisplayPaycheck();
            Console.ReadLine();
            job.DisplayJobInformation();
            Console.ReadLine();

            //Testing the overloaded constructor using user input

            Console.WriteLine("Please enter employee's First Name. ");
            strFirstName = Console.ReadLine();
            Console.WriteLine("Please enter employee's Last Name. ");
            strLastName = Console.ReadLine();
            Console.WriteLine("Please enter employee's Social Security Number. ");
            strSocialNumber = Console.ReadLine();
            Console.WriteLine("Please enter employee's Address. ");
            strAddress = Console.ReadLine();
            Console.WriteLine("Please enter employee's city of residance. ");
            strCity = Console.ReadLine();
            Console.WriteLine("Please enter employee's state of residance. ");
            strState = Console.ReadLine();
            Console.WriteLine("Please enter employee's zip code. ");
            strZip = Console.ReadLine();
            Console.WriteLine("Please enter employee's hourly pay. ");
            dblHourlyPay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter hours the employee worked. ");
            dblHoursWorked = Convert.ToDouble(Console.ReadLine());

            //Getting Information from user for the Job class

            Console.WriteLine("Please enter job name. ");
            strJobName = Console.ReadLine();
            Console.WriteLine("Please enter the main job duty. ");
            strMainJobDuty = Console.ReadLine();
            Console.WriteLine("Please enter hours for job. ");
            dblJobHours = Convert.ToDouble(Console.ReadLine());

            //Inputing data from the user into the overloaded constructor for Employee Class

            Employee emp1 = new Employee(strFirstName, strLastName, strSocialNumber, strAddress, strCity, strState, strZip, dblHourlyPay, dblHoursWorked);

            //Figureing amounts for Gross Pay, Net Pay, Federal and Social Withholding

            dblGrossPay = emp1.Pay();
            dblFedTaxWithheld = pc.GetFederalWithheld(dblGrossPay);
            dblSocialTaxWithheld = pc.GetSocialWithheld(dblGrossPay);
            dblNetPay = pc.GetNetPay(dblGrossPay, dblSocialTaxWithheld, dblFedTaxWithheld);

            //Inputing data using the overloaded constructor for the Paychack class

            PayCheck pc1 = new PayCheck(dblHourlyPay, dblHoursWorked, dblGrossPay, dblNetPay, dblFedTaxWithheld, dblSocialTaxWithheld);

            //Inputing data using the overloaded constructor for the Job class

            Job job1 = new Job(strJobName, strMainJobDuty, dblJobHours);

            //Calling the methods from the employee class

            emp1.Overtime = emp1.GetOvertime();
            emp1.NetPay = emp1.Pay();

            //Displaying the information from the Overloaded constructor.

            emp1.DisplayInformation();
            Console.ReadLine();
            pc1.DisplayPaycheck();
            Console.ReadLine();


        }
    }
}
