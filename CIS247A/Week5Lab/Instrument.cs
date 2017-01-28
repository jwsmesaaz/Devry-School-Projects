using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk5Lab
{
    public abstract class Instrument
    {
        //Declare Variables
        protected bool blnInTune;
        protected double dblCost;

        //Get/set methods
        public bool InTune
        {
            get { return blnInTune; }
            set { blnInTune = value; }
        }
        public double Cost
        {
            get { return dblCost; }
            set { dblCost = value; }
        }

        //Polymorphic method

        public virtual double CostWithTax()
        {
            
            Console.WriteLine("What is the cost of the instrument? ");
            dblCost = Convert.ToDouble(Console.ReadLine().Trim());

            dblCost = ((dblCost * .08050) + dblCost);


            return dblCost;
        }

        //Abstract method
        public abstract void GetInTune();
        
        
    }
}
