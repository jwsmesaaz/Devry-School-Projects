using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk4Lab
{
    class Schedule
    {
        //Declare variables
        private string strCourseName1;
        private string strCourseName2;
        private double dblCredits1;
        private double dblCredits2;

        //Constructor

        public Schedule() { }

        //Overloaded Constructor

        public Schedule(string strCourseName1, string strCourseName2, double dblCredits1, double dblCredits2)
        {
            this.strCourseName1 = strCourseName1;
            this.strCourseName2 = strCourseName2;
            this.dblCredits1 = dblCredits1;
            this.dblCredits2 = dblCredits2;
        }

        //Deconstructor
        ~Schedule() { }

        //Get/set methods
        public string CourseName1
        {
            get{return strCourseName1;}
            set{strCourseName1 = value;}
        }
        public string CourseName2
        {
            get { return strCourseName2; }
            set { strCourseName2 = value; }
        }
        public double Credits1
        {
            get { return dblCredits1; }
            set { dblCredits1 = value; }
        }
        public double Credits2
        {
            get { return dblCredits2; }
            set { dblCredits2 = value; }
        }

        //Method to display Schedule

        public void DisplaySchedule()
        {
            Console.WriteLine("Course 1 name is: " + strCourseName1);
            Console.WriteLine(dblCredits1 + " Credits are given for Course 1");
            Console.WriteLine("Course 2 name is: " + strCourseName2);
            Console.WriteLine(dblCredits2 + " Credits are given for Course 2");
        }
        public void CreditsTaken()
        {
            double dblTotalCredits = (dblCredits1 + dblCredits2);
            Console.WriteLine("Total credits taken is: " + dblTotalCredits);
        }

    }
}
