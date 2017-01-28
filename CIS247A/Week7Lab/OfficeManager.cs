using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk7Lab
{
    public class OfficeManager:Employee
    {
        //Declare Constants
        private const string strOfficeManager = "Office Manager";

        //Delcare variables
        private bool blnHasPhone;
        private int intNumberOfLines;
        private bool blnKnowsPasswords;

        //Declare objects

        private Payroll pr;

        //Constructor
        public OfficeManager ()
        {
            pr = new Payroll();
        }

        //Get/set methods
        public Payroll ThePayroll
        {
            get{return pr;}
            set{pr=value;}
        }
        public bool HasPhone
        {
            get{return blnHasPhone;}
            set{blnHasPhone=value;}
        }
        public int NumberOfLines
        {
            get{return intNumberOfLines;}
            set{intNumberOfLines=value;}
        }
        public bool KnowsPasswords
        {
            get{return blnKnowsPasswords;}
            set{blnKnowsPasswords=value;}
        }

        //Deconstructor
        ~OfficeManager(){}

    }
}
