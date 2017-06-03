using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bgn_usd_eur_gbp
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();

            double us = 1.79549;
            double eu = 1.95583;
            double gb = 2.53405;

            if (val1 == "USD")
                n = n * us;
            else if (val1 == "EUR")
                n = n * eu;
            else if (val1 == "GBP")
                n = n * gb;

            if (val2 == "USD")
                n = n / us;
            else if (val2 == "EUR")
                n = n / eu;
            else if (val2 == "GBP")
                n = n / gb;

            Console.WriteLine(Math.Round(n,2)+ "  " + val2);
        }
    }
}
