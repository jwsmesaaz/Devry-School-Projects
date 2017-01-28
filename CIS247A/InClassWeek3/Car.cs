using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk3
{
    class Car
    {
        //Declare Variables
        private string strMake;
        private string strModel;
        private int intYear;

        //declare object of radio class
        private Radio rd;

        //default Constructor
        public Car()
        {
            //Instantiate object of radio class

            rd = new Radio();
        }
        
        //

        public Car(string strMake, string strModel, int intYear)
        {
            //Instantiate object of radio class

            rd = new Radio();
            this.strMake = strMake;
            this.strModel = strModel;
            this.intYear = intYear;
        }

        //get set method

        public Radio RadioComp
        {
            get { return rd; }
            set { rd = value; }
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
        public int Year
        {
            get { return intYear; }
            set { intYear = value; }
        }
        public string Drive()
        {
            string strOutput;

            strOutput = "The car is now driving";

            return strOutput;
        }
    }
}
