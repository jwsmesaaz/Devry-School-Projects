using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk5Lab
{
    class Guitar : Instrument
    {
        //Variables
        private string strElectricOrAcoustic;
        private string strBrand;
        private int intStrings;

        //Default Constructor
        public Guitar() { }

        //Get/set methods
        public string ElectricOrAcoustic
        {
            get { return strElectricOrAcoustic; }
            set { strElectricOrAcoustic = value; }
        }
        public string Brand
        {
            get { return strBrand; }
            set { strBrand = value; }
        }
        public int Strings
        {
            get { return intStrings; }
            set { intStrings = value; }
        }

        //Override the absract
        public override void GetInTune()
        {
            bool[] blnInTune = new bool[intStrings];
            int i = 0;
            for (i = 0; i < blnInTune.Length; i++)
            {
                blnInTune[i] = false;
            }
            string strYesOrNo;


            if (intStrings == 6)
            {

                for (int x = 6; x > 0; x--)
                {
                    if (x == 6)
                    {
                        Console.WriteLine("Is the " + x + " string in tune? enter (Yes or No)");
                        strYesOrNo = Console.ReadLine().Trim().ToUpper();
                        if (strYesOrNo == "N")
                        {
                            strYesOrNo = "NO";
                        }

                        if (strYesOrNo == "NO")
                        {
                            Console.WriteLine("The first string or high 'E' coresponds to the 'E' higher than middle 'C' on a standard keyboard");

                            blnInTune[x-1] = true;
                        }
                        else
                        {
                            blnInTune[x-1] = true;
                        }
                    }
                    else if (x == 5)
                    {
                        Console.WriteLine("Is the " + x + " string in tune? enter (Yes or No)");
                        strYesOrNo = Console.ReadLine().Trim().ToUpper();
                        if (strYesOrNo == "N")
                        {
                            strYesOrNo = "NO";
                        }

                        if (strYesOrNo == "NO")
                        {
                            Console.WriteLine("Hold the 5th fret of the 6th string to get pitch of 5th string (A)");

                            blnInTune[x] = true;
                        }
                        else
                        {
                            blnInTune[x] = true;
                        }
                    }
                    else if (x == 4)
                    {
                        Console.WriteLine("Is the " + x + " string in tune? enter (Yes or No)");
                        strYesOrNo = Console.ReadLine().Trim().ToUpper();
                        if (strYesOrNo == "N")
                        {
                            strYesOrNo = "NO";
                        }

                        if (strYesOrNo == "NO")
                        {
                            Console.WriteLine("Hold the 5th fret of the 5th string to get pitch of 4th string (D)");

                            blnInTune[x] = true;
                        }
                        else
                        {
                            blnInTune[x] = true;
                        }
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Is the " + x + " string in tune? enter (Yes or No)");
                        strYesOrNo = Console.ReadLine().Trim().ToUpper();
                        if (strYesOrNo == "N")
                        {
                            strYesOrNo = "NO";
                        }

                        if (strYesOrNo == "NO")
                        {
                            Console.WriteLine("Hold the 5th fret of the 4th string to get pitch of 3rd string (G)");

                            blnInTune[x] = true;
                        }
                        else
                        {
                            blnInTune[x] = true;
                        }
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine("Is the " + x + " string in tune? enter (Yes or No)");
                        strYesOrNo = Console.ReadLine().Trim().ToUpper();
                        if (strYesOrNo == "N")
                        {
                            strYesOrNo = "NO";
                        }

                        if (strYesOrNo == "NO")
                        {
                            Console.WriteLine("Hold the 4th fret of the 3rd string to get pitch of 2nd string (B)");

                            blnInTune[x] = true;
                        }
                        else
                        {
                            blnInTune[x] = true;
                        }
                    }
                    else if (x == 1)
                    {
                        Console.WriteLine("Is the " + x + " string in tune? enter (Yes or No)");
                        strYesOrNo = Console.ReadLine().Trim().ToUpper();
                        if (strYesOrNo == "N")
                        {
                            strYesOrNo = "NO";
                        }

                        if (strYesOrNo == "NO")
                        {
                            Console.WriteLine("Hold the 5th fret of the 2nd string to get pitch of 1st string (E)");

                            blnInTune[x] = true;
                        }
                        else
                        {
                            blnInTune[x] = true;
                        }
                    }


                }

            }
            else
            {
                Console.WriteLine("I'm sorry this program only allows for tuning a six string guitar.");
                Console.WriteLine("Please upgrade to the full version to get all the extra features.");
            }
        }

        //Override polymorphic
        public override double CostWithTax()
        {     
            dblCost = dblCost + (dblCost * .0975);
            
            return dblCost;
        }

        public void TurnOn()
        {
            if (strElectricOrAcoustic == "ELECTRIC")
            {
                Console.WriteLine("Your guitar is on. The guitar will turn off after 5 min of no use.");
            }
            else
            {
                Console.WriteLine("I'm sorry your guitar is not an electronic guitar");
            }
        }
        
    }
}
