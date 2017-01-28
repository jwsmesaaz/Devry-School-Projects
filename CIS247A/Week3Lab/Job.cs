using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk3Lab
{
    class Job
    {
        //Declare Variables

        private string strJobName;
        private string strMainJobDuty;
        private double dblJobHours;

        //Constructor

        public Job() { }

        //Overloaded Constructor

        public Job(string strJobName, string strMainJobDuty, double dblJobHours)
        {
            this.strJobName = strJobName;
            this.strMainJobDuty = strMainJobDuty;
            this.dblJobHours = dblJobHours;
        }

        //Get/Set Methods

        public string JobName
        {
            get { return strJobName; }

            set { strJobName = value; }
        }
        public string MainJobDuty
        {
            get { return strMainJobDuty; }

            set { strMainJobDuty = value; }
        }
        public double JobHours
        {
            get { return dblJobHours; }

            set { dblJobHours = value; }
        }

        //Deconstructor

        ~Job() { }

        //Display Job information Method

        public void DisplayJobInformation()
        {
            Console.WriteLine("Job Name        " + strJobName);
            Console.WriteLine("Main Job Duty   " + strMainJobDuty);
            Console.WriteLine("Job hourly Pay  " + dblJobHours);                
        }
    }
}
