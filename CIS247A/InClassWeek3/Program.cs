using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWk3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio rd = new Radio(11, 3, "100.7");

            Console.WriteLine(rd.DisplayVolume());

            Car cr = new Car();

            cr.RadioComp.Channel = 5;
            cr.RadioComp.Station = "97.9";
            cr.RadioComp.Volume = 13;

            Console.WriteLine(cr.RadioComp.DisplayVolume());
            Console.ReadLine();
        }
    }
}
