using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk6
{
    class StuffedCrust:Pizza
    {
        //Variables
        private string strTypeOfPizza;
        private string strPizzaSize;
        private int intTimeToBake;

        //Constructor
        public StuffedCrust() { }

        //Get/set method
        public string TypeOfPizza
        {
            get { return strTypeOfPizza; }
            set { strTypeOfPizza = value; }
        }
        public string PizzaSize
        {
            get {return strPizzaSize;}
            set { strPizzaSize = value; }
        }
        public int TimeToBake
        {
            get { return intTimeToBake; }
            set { intTimeToBake = value; }
        }

        //Override abstract method
        public override void Toppings()
        {
            if (strTypeOfPizza == "MEAT")
            {
                Console.WriteLine("Put Cheese, Ham, Sausage, and Pepporoni on the pizza");
            }
            else if (strTypeOfPizza == "HAWAIAN")
            {
                Console.WriteLine("Put Cheese, Ham, and Pineapple on the pizza");
            }
            else if (strTypeOfPizza == "CHEESE")
            {
                Console.WriteLine("Put only Cheese on the pizza");
            }
            else
            {
                Console.WriteLine("An error occured please restart the program and enter type of pizza.");
            }
        }

        //Override polymorphic method
        public override int Bake(string strTypeOfPizza)
        {
            bool blnPizza = false;
            do
            {
                if (strTypeOfPizza == "MEAT")
                {                   
                    intTimeToBake = 16;
                    blnPizza = true;
                    return intTimeToBake;                    
                }
                else if (strTypeOfPizza == "HAWAIAN")
                {
                    intTimeToBake = 14;
                    blnPizza = true;
                    return intTimeToBake; 
                }
                else if (strTypeOfPizza == "CHEESE")
                {
                    intTimeToBake = 12;
                    blnPizza = true;
                    return intTimeToBake;                    
                }
                else
                {                    
                    blnPizza = false;
                    intTimeToBake = 20;
                    return intTimeToBake;
                }
            } 
            while (blnPizza == false);
        }
        public override string TheTypeOfPizza()
        {
            bool blnPizza = false;
            do
            {

                Console.WriteLine("What type of pizza are you baking?");
                Console.WriteLine("If meat type one(1) if hawaian type two(2) if cheese type three(3)");
                strTypeOfPizza = Console.ReadLine().Trim();
                if (strTypeOfPizza == "1")
                {

                    strTypeOfPizza = "MEAT";
                    blnPizza = true;
                    return strTypeOfPizza;

                }
                else if (strTypeOfPizza == "2")
                {
                    strTypeOfPizza = "HAWAIAN";
                    blnPizza = true;
                    return strTypeOfPizza;

                }
                else if (strTypeOfPizza == "3")
                {
                    strTypeOfPizza = "CHEESE";
                    blnPizza = true;
                    return strTypeOfPizza;

                }
                else
                {
                    Console.WriteLine("You must enter either 1, 2, or 3");
                    blnPizza = false;
                    strTypeOfPizza = null;
                    return strTypeOfPizza;
                }
            } while (blnPizza == false);
        }
        public double TheCost(string strTypeOfPizza)
        {
            bool blnPizza = false;
            do
            {
                if (strTypeOfPizza == "MEAT")
                {
                    dblCost = 12.00;
                    blnPizza = true;
                    return dblCost;
                }
                else if (strTypeOfPizza == "HAWAIAN")
                {
                    dblCost = 14.00;
                    blnPizza = true;
                    return dblCost;
                }
                else if (strTypeOfPizza == "CHEESE")
                {
                    dblCost = 7.50;
                    blnPizza = true;
                    return dblCost;
                }
                else
                {
                    blnPizza = false;
                    dblCost = 20;
                    return dblCost;
                }
            }
            while (blnPizza == false);
        }


    }
}
