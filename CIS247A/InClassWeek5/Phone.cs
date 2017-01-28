using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk5
{
    public abstract class Phone
    {
        //Variables
        protected string strPhoneNumber;
        protected double dblCost;

        //Don't need constructor

        //Get/set Methods
        public string PhoneNumber
        {
            get { return strPhoneNumber; }
            set { strPhoneNumber = value; }
        }
        public double Cost
        {
            get { return dblCost; }
            set { dblCost = value; }
        }

        //Other methods
        public virtual void PlaceCall()
        {
            string strInput = "";
            bool blnIsValidNumber = false;
            do
            {
                
                Console.WriteLine("Please enter number you would like to call.");
                Console.WriteLine("enter numbers only: (ex: 15555555555");                
                strInput = Console.ReadLine();

                long lgNumber = 0;
                if (long.TryParse(strInput, out lgNumber) == true)
                {
                    blnIsValidNumber = true;
                }

            } while (blnIsValidNumber == false);
            Console.WriteLine("dialing..." + strInput);
        }
        public abstract void TurnOn();


        

    }
}
