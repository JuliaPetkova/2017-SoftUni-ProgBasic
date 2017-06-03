using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string In = Console.ReadLine();
            string Out = Console.ReadLine();

            double us = 1.79549;
            double eu = 1.95583;
            double gb = 2.53405;

            if (In == "USD")
            {
                n = n * us;
            }

            else if (In == "EUR")
            {
                n = n * eu;
            }
            else if (In == "GBP")
            {
                n = n * gb;
            }

            //изход:

            if (Out == "USD")
            {
                n = n / us;
            }

            else if (Out == "EUR")
            {
                n = n / eu;
            }
            else if (Out == "GBP")
            {
                n = n / gb;
            }

            Console.WriteLine("{0} {1}", Math.Round(n, 2), Out);
            //Console.WriteLine(Math.Round(n, 2) + "  " + Out);
        }
    }
}
