using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk5
{
    class Animal
    {
        //Declare Varibales
        protected bool blnIsAlive;
        protected int intNumberOfEyes;
        protected bool blnHasLegs;
        protected double dblWeight;

        //Default Consructor
        public Animal() { }

        //Get/set methods
        public bool IsAlive
        {
            get { return blnIsAlive; }
            set { blnIsAlive = value; }
        }
        public bool HasLegs
        {
            get { return blnHasLegs; }
            set { blnHasLegs = value; }
        }
        public int NumberOfEyes
        {
            get { return intNumberOfEyes; }
            set { intNumberOfEyes = value; }
        }
        public double Weight
        {
            get { return dblWeight; }
            set { dblWeight = value; }
        }

        //Methods
        public virtual string Reproduce()
        {
            string strOutput = "";

            strOutput = "The animal is now reproducing!!!";

            return strOutput;
        }
        public virtual string Eat()
        {
            string strOutput = "";

            strOutput = "The animal is now eating";

            return strOutput;
        }
        public virtual string Sleep()
        {
            string strOutput = "";

            strOutput = "The animal is now sleeping.";

            return strOutput;
        }
    }
}
