using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk5
{
    class CellPhone:Phone
    {
        //Variables
        private string strModel;
        private string strStyle;
        private bool blnVibrate;
        private bool blnIsOn;

        //Get/set methods
        public string Model
        {
            get { return strModel; }
            set { strModel = value; }
        }
        public string Style
        {
            get { return strStyle; }
            set { strStyle = value; }
        }
        public bool Vibrate
        {
            get { return blnVibrate; }
            set { blnVibrate = value; }
        }
        public bool IsOn
        {
            get { return blnIsOn; }
            set { blnIsOn = value; }
        }

        //Program abstract methods
        public override void TurnOn()
        {
            if (blnIsOn == true)
            {
                Console.WriteLine("The phone is on");
            }
            else
            {
                Console.WriteLine("The phone is off");
            }
        }
        public void DisplayVibrate()
        {
            if (blnVibrate == true)
            {
                Console.WriteLine("The Vibrate is on");
            }
            else
            {
                Console.WriteLine("The Vibrate is off");
            }
        }


    }
}
