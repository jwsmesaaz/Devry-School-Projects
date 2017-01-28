using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWeek4
{
    public class Motorcycle
    {
        //Declare Variables

        protected int intTireCount;
        protected string strMake;
        protected string strModel;

        //Default constructor

        public Motorcycle() { }

        //Get/set for Variables

        public int TireCount
        {
            get { return intTireCount; }
            set { intTireCount = value; }
        }
        public string Make
        {
            get { return strMake; }
            set { strMake = value; }
        }
        public string Model
        {
            get { return strModel; }
            set { strModel = value; }
        }

        //Method to display info about motocycle

        public string DisplayMotorcycleInfo()
        {
            string strOutPut = "";

            strOutPut += "The make of the motorcycle is: " + Make + "\n\n";
            strOutPut += "The model of the motorcycle is: " + Model + "\n\n";
            strOutPut += "The motorcycle has: " + TireCount + "\n\n";

            return strOutPut;
        }

        //Virtual overridable method

        public virtual string StartEngine()
        {
            string strOutPut = "";

            strOutPut += "This method is being called and used from the base class";
            
            return strOutPut;
        }
    }
}
