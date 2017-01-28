using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmithWk6Lab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Program Version
            String stringVersion = "6.0";
            DisplayTitle(stringVersion);       


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(stringVersion));
        }
        static void DisplayTitle(String stringVersion)
        {
            MessageBox.Show("Thank you for choosing Pay Calculator " + stringVersion + ".");
        }
    }
}
