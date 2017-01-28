using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string strCourseName1;
            string strCourseName2;
            double dblCredits1;
            double dblCredits2;
            string strStudentName;
            double dblGPA;
            string strGradeLevel;            
            string strSpecialization;
            double dblYearsLeft;

            CISMajor cis = new CISMajor();            

            Console.WriteLine("Pleae enter first course name.");
            strCourseName1 = Console.ReadLine().Trim();
            cis.TheSchedule.CourseName1 = strCourseName1;
            Console.WriteLine("Please enter amount of credits for " + strCourseName1 + ".");
            dblCredits1 = Convert.ToDouble(Console.ReadLine().Trim());
            cis.TheSchedule.Credits1 = dblCredits1;
            Console.WriteLine("Pleae enter second course name.");
            strCourseName2 = Console.ReadLine().Trim();
            cis.TheSchedule.CourseName2 = strCourseName2;
            Console.WriteLine("Please enter amount of credits for " + strCourseName2 + ".");
            dblCredits2 = Convert.ToDouble(Console.ReadLine().Trim());
            cis.TheSchedule.Credits2 = dblCredits2;
            Console.WriteLine("Please enter student's name.");
            strStudentName = Console.ReadLine().Trim();
            cis.StudentName = strStudentName;
            Console.WriteLine("Please enter student's GPA.");
            dblGPA = Convert.ToDouble(Console.ReadLine().Trim());
            cis.GPA = dblGPA;
            Console.WriteLine("Please enter student's grade Level (ie Senoir, Junior, Sophmore, Freshmen).");
            strGradeLevel = Console.ReadLine().Trim().ToUpper();
            strGradeLevel = cis.NameGradeLevel();
            cis.GradeLevel = strGradeLevel;
            strSpecialization = cis.TheSpecialization();
            cis.Specialization = strSpecialization;
            dblYearsLeft = cis.TheYearsLeft();

            Console.ReadLine();

            //Testing Overloaded Constructors
            Student stu1 = new Student(strStudentName, dblGPA, strGradeLevel);
            CISMajor cis1 = new CISMajor(strSpecialization, dblYearsLeft);
            cis1.TheSchedule = new Schedule(strCourseName1, strCourseName2, dblCredits1, dblCredits2);

            Console.ReadLine();

            //Testing methods
            cis.DropClass(strCourseName1, strCourseName2);
            string strGraduate = cis.Graduate();
            cis.TheSchedule.CreditsTaken();
            cis.TheSchedule.DisplaySchedule();
            cis.ClassesNeeded();

            Console.ReadLine();

            cis1.DropClass(strCourseName1, strCourseName2);
            strGraduate = cis1.Graduate();
            cis1.TheSchedule.CreditsTaken();
            cis1.TheSchedule.DisplaySchedule();
            cis1.ClassesNeeded();


            Console.ReadLine();
        }
    }
}
