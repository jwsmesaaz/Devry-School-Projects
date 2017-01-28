using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk6
{
    public abstract class Pizza
    {
        //Variables
        protected double dblCost;
        protected string strCrust;

        //Get/set methods
        public double Cost
        {
            get { return dblCost; }
            set { dblCost = value; }
        }
        public string Crust
        {
            get { return strCrust; }
            set { strCrust = value; }
        }

        //Abstract method
        public abstract void Toppings();
        public abstract string TheTypeOfPizza();

        //Polymorphic method
        public virtual int Bake(string strTypeOfPizza)
        {
            int intTimeToBake;
            Console.WriteLine("Your pizza will be ready in 10 - 20 min.");
            intTimeToBake = 20;
            return intTimeToBake;
        }

        
        
    }
}
