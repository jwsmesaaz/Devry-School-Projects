using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk3
{
    class Warehouse
    {
        //Variable

        private int intNumberOfRadios;
        private int intNumberOfTVs;
        private int intNumberOfComputers;

        //Constructor

        public Warehouse() { }

        //Overloaded Constructor

        public Warehouse(int t, int r, int c)
        {
            intNumberOfTVs = t;
            intNumberOfRadios = r;
            intNumberOfComputers = c;
        }

        public int Radio
        {
            get {return intNumberOfRadios;}
            set {intNumberOfRadios = value;}
        }
        public int TV
        {
            get { return intNumberOfTVs; }
            set { intNumberOfTVs = value; }
        }
        public int Computer
        {
            get { return intNumberOfComputers; }
            set { intNumberOfComputers = value; }
        }

        
    }
}
