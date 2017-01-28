using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk3
{
    class Radio
    {
        //Declare variables
        private short shVolume;
        private short shChannel;
        private string strStations;

        //Constructor

        public Radio() { }

        //Overload Constructor

        public Radio(short shVolume, short shChannel, string strStations)
        {
            this.shVolume = shVolume;
            this.shChannel = shChannel;
            this.strStations = strStations;
        }

        //Get-sets

        public short Volume
        {
            get {return shVolume;}
            set { shVolume = value; }
        }
        public short Channel
        {
            get { return shChannel ; }
            set { shChannel = value; }
        }
        public string Station
        {
            get { return strStations; }
            set { strStations = value; }
        }

        //Methods for Volume control

        public string DisplayVolume()
        {
            string strOutput = "";

            strOutput = "The volume of the radio is " + Volume;

            return strOutput;
        }
    }
}
