using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk5
{
    class Lygar:Animal
    {
        //Variables
        private bool blnHasFur;
        private bool blnIsCarnivore;

        //Default Constructor
        public Lygar() { }

        //Get/set Methods
        public bool HasFur
        {
            get { return blnHasFur; }
            set { blnHasFur = value; }
        }
        public bool IsCarnivore
        {
            get { return blnIsCarnivore; }
            set { blnIsCarnivore = value; }
        }

        //Overriing methods
        public override string Reproduce()
        {
            string strOutput = "";

            strOutput = "The lygar cannot reproduce";

            return strOutput;
        }
        public override string Eat()
        {
            string strOutput = "";

            strOutput = "The lygar is now eating";

            return strOutput;
        }
        public override string Sleep()
        {
            string strOutput = "";

            strOutput = "The lygar is now sleeping";

            return strOutput;
        }

        //Methods for Lygar


    }
}
