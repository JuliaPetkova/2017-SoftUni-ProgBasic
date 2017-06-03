using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_2_ShopSofiaVarnaPl
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower(); // няма да върви, защото първо трябва да бъде продукта
            string product = Console.ReadLine().ToLower();

            double quantity = double.Parse(Console.ReadLine());

            if (town != "sofia" && town != "plovdiv" && town != "varna")
            {
                Console.WriteLine("Invalid town");
                return;
            }

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                if (product == "vater")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                if (product == "sweet")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            if (town == "plovdiv")
            {

            }
        }
    }
}
