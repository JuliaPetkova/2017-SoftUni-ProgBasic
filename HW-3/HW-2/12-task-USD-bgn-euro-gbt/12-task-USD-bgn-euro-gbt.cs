using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_USD_bgn_euro_gbt
{
    class Program
    {
        static void Main(string[] args)
        {
            double SUM = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();// Enter BGN, USD, EUR or GBP
            string output = Console.ReadLine();// Enter BGN, USD, EUR or GBP

            double bgn = 1.0;
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            switch (input)                  // Вход - преобразуваме в ЛЕВА
            {
                case "BGN": break;
                case "USD": SUM = SUM * usd; break;
                case "EUR": SUM = SUM * eur; break;
                case "GBP": SUM = SUM * gbp; break;
                default: break;          
            }
            switch (output)                 // Изход - ЛЕВА делим на коефициента 
            {
                case "BGN": SUM = SUM / bgn; break;
                case "USD": SUM = SUM / usd; break;
                case "EUR": SUM = SUM / eur; break;
                case "GBP": SUM = SUM / gbp; break;
                default: break;
            }
            Console.WriteLine(Math.Round(SUM, 2) + " " + output);
        }
    }
}
