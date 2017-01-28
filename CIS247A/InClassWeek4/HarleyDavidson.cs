using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWeek4
{
    public class HarleyDavidson:Motorcycle
    {
        //Declare Variables
        private double dblPrice;

        //Defaut constructor
        public HarleyDavidson() { }

        //Get/set methods

        public double Price
        {
            get { return dblPrice; }
            set { dblPrice = value; }
        }

        public string DisplayHarleyInfo()
        {
            string strOutPut = "";

            strOutPut = "The price of the Harley is: " + Price;
            
            return strOutPut;
        }

        //Override method

        public override string StartEngine()
        {
            string strOutPut = "";

            strOutPut += "This method is being called and used from the child class";
            
            return strOutPut;
        }
        public string StartEngineBase()
        {
            return base.StartEngine();
        }

    }
}
