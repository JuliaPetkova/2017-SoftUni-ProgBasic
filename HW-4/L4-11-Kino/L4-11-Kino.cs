using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_11_Kino
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            switch (type)
            {
                case "Premiere":
                    Console.WriteLine("{0:F2} leva", 12 * r * c);
                    break;
                case "Normal":
                    Console.WriteLine("{0:F2} leva", 7.50 * r * c);
                    break;
                case "Discount":
                    Console.WriteLine("{0:F2} leva", 5.0 * r * c);
                    break;

                default:
                    break;
            }
        }
    }
}
