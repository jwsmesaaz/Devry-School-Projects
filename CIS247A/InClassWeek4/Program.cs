using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InClassWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            HarleyDavidson hd = new HarleyDavidson();

            Console.WriteLine(hd.StartEngine());
            Console.WriteLine(hd.StartEngineBase());
            Console.ReadLine();
        }
    }
}
