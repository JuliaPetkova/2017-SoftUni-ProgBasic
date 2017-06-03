using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string inp = Console.ReadLine();
            string outp = Console.ReadLine();

            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            switch (inp)
            {
                case "BGN": break;
                case "USD": n = n * usd; break;
                case "EUR": n = n * eur; break;
                case "GBP": n = n * eur; break;
                default: break;
            }

            switch (outp)
            {
                case "BGN": break;
                case "USD": n = n / usd; break;
                case "EUR": n = n / eur; break;
                case "GBP": n = n / gbp; break;
                default: break;
            }

            Console.WriteLine(Math.Round(n, 2) + " " + outp);
        }
    }
}
