using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let user set amount of arrays
            Console.WriteLine("How many guitars do you have?");
            int intGuitars = Convert.ToInt32(Console.ReadLine().Trim());

            

            //Array
            Guitar[] arG = new Guitar[intGuitars];

            //Instantiate all objects of Guitar array
            for (int i = 0; i < arG.Length; i++)
            {
                arG[i] = new Guitar();
            }

            //use set methods

            for (int s = 0; s < arG.Length; s++)
            {
                //Variables
                int intStrings;
                int j = 0;

                //Getting information from user

                //Get the Cost of the guitar
                Console.WriteLine("Please enter the cost of the guitar.");
                arG[s].Cost = Convert.ToDouble(Console.ReadLine().Trim());
                
                //How many strings are on the guitar?
                Console.WriteLine("How many strings are on your guitar?");
                intStrings = Convert.ToInt32(Console.ReadLine().Trim());
                arG[s].Strings = intStrings;
                
                //Brand of guitar
                Console.WriteLine("What is the brand of guitar?");
                arG[s].Brand = Console.ReadLine().Trim();
            
                //Find out is the guitar is electric or acoustic
                
                do
                {
                    j++;
                    
                    Console.WriteLine("Please enter one(1) if the guitar is electric");
                    Console.WriteLine("Please enter two(2) if the guitar is acoustic");
                    string strElectricOrAcoustic = Console.ReadLine().Trim();
                    if (strElectricOrAcoustic == "1")
                    {
                        arG[s].ElectricOrAcoustic = "ELECTRIC";
                        break;
                    }
                    else if (strElectricOrAcoustic == "2")
                    {
                        arG[s].ElectricOrAcoustic = "ACOUSTIC";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a correct value make sure to only press 1 or 2");
                    }
                }while (j < 5);


                //See if guitar is in tune
                Console.WriteLine("Is the guitar in tune? (Yes or No)");
                if (Console.ReadLine().Trim().ToUpper() == "Y")
                {
                    arG[s].InTune = true;
                }
                else if (Console.ReadLine().Trim().ToUpper() == "YES")
                {
                    arG[s].InTune = true;
                }
                else if (intStrings != 6)
                {
                    arG[s].InTune = false;
                    Console.WriteLine("We are sorry this software only does tuning for a six string guitar. If you");
                    Console.WriteLine("would like to upgrade please ask store clerk for more details.");
                }
                else
                {
                    arG[s].InTune = false;
                    Console.WriteLine("We are sorry let us help you tune it with this free software");
                    arG[s].TurnOn();
                    arG[s].GetInTune();
                }

                //Calling methods
                Console.WriteLine("Thank you for choosing the " + arG[s].Brand + " guitar");
                Console.WriteLine("The final cost is {0:c} after tax.", +arG[s].CostWithTax());

                //Pause before going to next array
                Console.ReadLine();
            }
            
            
        }
        
    }
}
