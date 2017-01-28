using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lygar lg = new Lygar();

            //lg.HasFur = true;
            //lg.HasLegs = true;
            //lg.NumberOfEyes = 4;
            //lg.Weight = 600.00;
            //lg.IsCarnivore = true;
            //lg.IsAlive = true;

            ////Called Polymorphic methods
            //Console.WriteLine(lg.Reproduce());
            //Console.WriteLine(lg.Sleep());
            //Console.WriteLine(lg.Eat());
            //Console.ReadLine();

            CellPhone cp = new CellPhone();

            cp.TurnOn();
            cp.DisplayVibrate();

            cp.IsOn = true;
            cp.Vibrate = true;
            cp.Model = "Blackberry Storm";
            cp.Style = "Touch";
            cp.PhoneNumber = "(602)555-5555";

            //calling method not overridden
            cp.PlaceCall();

            //Override abstract Method
            cp.TurnOn();

            //Calling method
            cp.DisplayVibrate();

            Console.ReadLine();



            for (int s = 0; s < arCP.Length; s++)
            {
                cp.TurnOn();
                cp.DisplayVibrate();

                cp.IsOn = true;
                cp.Vibrate = true;
                cp.Model = "Blackberry Storm";
                cp.Style = "Touch";
                cp.PhoneNumber = "(602)555-5555";

                //calling method not overridden
                cp.PlaceCall();

                //Override abstract Method
                cp.TurnOn();

                //Calling method
                cp.DisplayVibrate();

                Console.ReadLine();
            }

        }
    }
}
