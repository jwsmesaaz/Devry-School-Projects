using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk4Lab
{
    class CISMajor:Student
    {
        //Variables
        private string strSpecialization;
        private double dblYearsLeft;
        private string strClassesNeeded;

        //Constructor
        public CISMajor() { }

        //Overloaded Constructor
        public CISMajor(string strSpecialization, double dblYearsLeft)
        {
            this.strSpecialization = strSpecialization;
            this.dblYearsLeft = dblYearsLeft;
        }

        //Get/set methods
        public string Specialization
        {
            get{return strSpecialization;}
            set{strSpecialization = value;}
        }
        public double YearsLeft
        {
            get { return dblYearsLeft; }
            set { dblYearsLeft = value; }
        }

        //Methods
        public string TheSpecialization()
        {
            int intSpec = 0;
            do
            {
                
                Console.WriteLine("What Specialization are you going for in the CIS Major?");
                Console.WriteLine("Computer Forensics press one(1) then enter.");
                Console.WriteLine("Database Management press two(2) then enter.");
                Console.WriteLine("Web Game Programming press three(3) then enter.");
                intSpec = Convert.ToInt16(Console.ReadLine());
                if (intSpec == 1)
                {
                    strSpecialization = "Computer Forensics";
                }
                else if (intSpec == 2)
                {
                    strSpecialization = "Database Management";
                }
                else if (intSpec == 3)
                {
                    strSpecialization = "Web Game Programming";
                }
                else
                {
                    Console.WriteLine("You must enter a number 1, 2, or 3 then press enter.");
                    intSpec = 0;
                }
            } while (intSpec == 0);



            return strSpecialization;
        }        
        public string ClassesNeeded()
        {
            if (strSpecialization == "Computer Forensics")
            {
                strClassesNeeded = "CCSI330, CCSI360, CCSI410, CCSI460, SEC440, CIS470";
            }
            else if (strSpecialization == "Database Management")
            {
                strClassesNeeded = "DBM405, DBM438, DBM449, SEC360, CIS470";
            }
            else if (strSpecialization == "Web Game Programming")
            {
                strClassesNeeded = "WBG340, WBG370, WBG410, WBG450, CIS470";
            }
            return strClassesNeeded;
        }
        public override double TheYearsLeft()
        {
            if (strSpecialization == "Computer Forensics")
            {
                dblYearsLeft = 17;
            }
            else if (strSpecialization == "Database Management")
            {
                dblYearsLeft = 20;
            }
            else if (strSpecialization == "Web Game")
            {
                dblYearsLeft = 16;
            }
            return dblYearsLeft;
        }

    }
}
