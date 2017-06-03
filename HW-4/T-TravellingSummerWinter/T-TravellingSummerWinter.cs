using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_TravellingSummerWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();

            if (budjet > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", budjet * 90 / 100); // закръгление до 2-ри знак
            }
            else if (budjet <= 1000 && budjet > 100)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (seson == "summer")
                {
                    Console.WriteLine("Camp - {0:F2}", budjet * 40 / 100);
                }
                else // ako бюджета е <=100
                {
                    Console.WriteLine("Hotel - {0:F2}", budjet * 80 / 100);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (seson == "summer")
                {
                    Console.WriteLine("Camp - {0:F2}", budjet * 30 / 100);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:F2}", budjet * 70 / 100);
                }
            }
        }
    }
}
