// ------------------------------------------------------------------
// Programming Assignment:		LAB1C
// Developer:				    Jon Smith
// Date Written:			    Tuesday, March 09, 2010
// Purpose:				        The program inputs number of adult and child tickets
//					            and outputs total cost.
// -------------------------------------------------------------------

using System;

class TicketCalc
{
    static void Main()
    {
        string userEntry;
        int adultPrice = 10;
        int childPrice = 7;
        int adultTkts;
        int childTkts;
        int totalCost;

        Console.Write("Enter number of adult tickets: ");
        userEntry = Console.ReadLine();
        adultTkts = Convert.ToInt32(userEntry);

        Console.Write("Enter number of child tickets: ");
        childTkts = Convert.ToInt32(Console.ReadLine());

        totalCost = adultTkts * adultPrice + childTkts * childPrice;
        Console.WriteLine("The total cost is $" + totalCost);
    }
}