/*****************************************************************************
 * Programming Assignment:		LAB1D.	 		                			 *
 * Developer:				    Jon Smith			                         *
 * Date Written:			    Tuesday, March 09, 2010	          		     *
 * Purpose:				        This program will request a name,		     *
 *					            prints the name 5 times, and		         *
 *					            rings a bell					             *
 *****************************************************************************/

using System;

namespace LAB1D
{
    class Class1
    {
        static void Main()
        {
            int ctr = 0;	// integer variable to count thru loop
            string fname;	// string variable to hold first name

            Console.Write("Enter your first name: "); // prompts user
            fname = Console.ReadLine(); // gets name from keyboard
            while (ctr < 5) // loop to print the name
            {
                Console.WriteLine(fname + "\n");
                ctr++;	 // increments ctr by 1
            }
            Console.WriteLine("\a"); // rings the bell
        }
    }
}