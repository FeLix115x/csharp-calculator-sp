using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kalkulators
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */

            string expr = "4 * (-21 + 4)";

            ExpressionParser e = new ExpressionParser();
            Console.WriteLine(e.ExecuteStringEquation(expr));

        }
    }
}
