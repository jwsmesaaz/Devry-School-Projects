using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk4Lab
{
    class Student
    {
        //Declare Variables
        private string strStudentName;
        private double dblGPA;
        private string strGradeLevel;
        private double dblYearsLeft = 4;
        private Schedule sch;

        //Constructor
        public Student() 
        { 
            sch = new Schedule();
        }

        //Overloaded Constructor
        public Student(string strStudentName, double dblGPA, string strGradeLevel)
        {
            this.strStudentName = strStudentName;
            this.dblGPA = dblGPA;
            this.strGradeLevel = strGradeLevel;

            sch = new Schedule();
        }

        //Get/set methods
        public string StudentName
        {
            get { return strStudentName; }
            set {strStudentName = value;}
        }
        public double GPA
        {
            get { return dblGPA; }
            set { dblGPA = value; }
        }
        public string GradeLevel
        {
            get { return strGradeLevel; }
            set { strGradeLevel = value; }
        }
        public Schedule TheSchedule
        {
            get { return sch; }
            set { sch = value; }
        }

        //Methods
        public string Graduate()
        {
            string strGraduate;
                if(strGradeLevel == "12" || strGradeLevel == "SENOIR")
                {
                    strGraduate = "Yes";
                }
                else
                {
                    strGraduate = "No";
                }
            return strGraduate;
        }
        public virtual void DropClass(string strCourseName1, string strCourseName2)
        {  
            string strDrop;

            //Find out if the user they want to drop the first course
            Console.WriteLine("Do you want to drop " + strCourseName1 + " ?");
            strDrop = Console.ReadLine().ToUpper();
            if (strDrop == "Y")
            {
                sch.CourseName1 = "";
            }
            else if (strDrop == "YES")
            {
                sch.CourseName1 = "";
            }
            //Find out if the user wants to drop the second course
            Console.WriteLine("Do you want to drop " + strCourseName2 + " ?");
            strDrop = Console.ReadLine().ToUpper();
            if (strDrop == "Y")
            {
                sch.CourseName2 = "";
            }
            else if (strDrop == "YES")
            {
                sch.CourseName2 = "";
            } 
        }
        public virtual string NameGradeLevel()
        {

            if (strGradeLevel == "12" || strGradeLevel == "SENOIR")
            {
                strGradeLevel = "SENOIR";
            }
            else if (strGradeLevel == "11" || strGradeLevel == "JUNIOR")
            {
                strGradeLevel = "JUNIOR";
            }
            else if (strGradeLevel == "10" || strGradeLevel == "SOPHOMORE")
            {
                strGradeLevel = "SOPHOMORE";
            }
            else if (strGradeLevel == "9" || strGradeLevel == "FRESHMEN")
            {
                strGradeLevel = "FRESHMEN";
            }
            return strGradeLevel;
        }
        public virtual double TheYearsLeft()
        {            
            if (strGradeLevel == "SENOIR")
            {
                dblYearsLeft = 1;
            }
            else if (strGradeLevel == "JUNIOR")
            {
                dblYearsLeft = 2;
            }
            else if (strGradeLevel == "SOPHMORE")
            {
                dblYearsLeft = 3;
            }
            else if (strGradeLevel == "FRESHMEN")
            {
                dblYearsLeft = 4;
            }

            return dblYearsLeft;
        }

    }
}
