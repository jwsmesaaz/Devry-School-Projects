using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmithWk7Lab
{
    public abstract class Employee
    {
        //Variables     

        protected string strFirstName;
        protected string strLastName;
        protected string strSocialSecurity;
        protected string strAddressStreet;
        protected string strAddressCity;
        protected string strAddressState;
        protected string strAddressZip;
        protected string strPhoneNumber;
        protected DateTime dtHireDate;

        //Get/set methods

        public string FirstName
        {
            get { return strFirstName; }
            set { strFirstName = value; }
        }
        public string LastName
        {
            get { return strLastName; }
            set { strLastName = value; }
        }
        public string SocialSecurity
        {
            get { return strSocialSecurity; }
            set { strSocialSecurity = value; }
        }
        public string AddressStreet
        {
            get { return strAddressStreet; }
            set { strAddressStreet = value; }
        }
        public string AddressCity
        {
            get { return strAddressCity; }
            set { strAddressCity = value; }
        }
        public string AddressState
        {
            get { return strAddressState; }
            set { strAddressState = value; }
        }
        public string AddressZip
        {
            get { return strAddressZip; }
            set { strAddressZip = value; }
        }
        public string PhoneNumber
        {
            get { return strPhoneNumber; }
            set { strPhoneNumber = value; }
        }
        public DateTime HireDate
        {
            get { return dtHireDate; }
            set { dtHireDate = value; }
        }
        

    }
}
