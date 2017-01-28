using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk6
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTypeOfPizza;

            StuffedCrust[] arSC = new StuffedCrust[2];

            //instantiate all objects of cellphone array
            for (int i = 0; i < arSC.Length; i++)
            {
                arSC[i] = new StuffedCrust();
            }

            for (int s = 0; s < arSC.Length; s++)
            {
                Console.WriteLine("Thank you for choosing stuffed crust");
                arSC[s].Crust = "Stuffed";
                Console.WriteLine("What size of Pizza do you want?");
                arSC[s].PizzaSize = Console.ReadLine();
                strTypeOfPizza = arSC[s].TheTypeOfPizza();
                arSC[s].TypeOfPizza = strTypeOfPizza;
                arSC[s].TimeToBake = arSC[s].Bake(strTypeOfPizza);
                arSC[s].Cost = arSC[s].TheCost(strTypeOfPizza);

            }
        }
    }
}
