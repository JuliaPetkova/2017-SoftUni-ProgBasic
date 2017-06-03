using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Convert_Meters_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            switch (input)
            {
                case "mm":
                    n = n / 1000;
                    break;

                case "cm":
                    n = n / 100;
                    break;

                case "mi":
                    n = n / 0.000621371192;
                    break;

                case "in":
                    n = n / 39.3700787;
                    break;

                case "km":
                    n = n / 0.001;
                    break;

                case "ft":
                    n = n / 3.2808399;
                    break;

                case "yd":
                    n = n / 1.093613;
                    break;

                default:
                    break;
            }

            switch (output)
            {
                case "mm":
                    n = n * 1000;
                    break;

                case "cm":
                    n = n * 100;
                    break;

                case "mi":
                    n = n * 0.000621371192;
                    break;

                case "in":
                    n = n * 39.3700787;
                    break;

                case "km":
                    n = n * 0.001;
                    break;

                case "ft":
                    n = n * 3.2808399;
                    break;

                case "yd":
                    n = n * 1.093613;
                    break;

                default:
                    break;

            }

            Console.WriteLine(n+" "+ output);

        }
    }
}
