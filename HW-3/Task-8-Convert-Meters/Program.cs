using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Convert_Meters
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); // crd
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double mms = 1/1000.00;
            double cms = 1/100.00;
            double mis = 1/0.000621371192;
            double incs = 1/39.3700787;
            double kms = 1/0.001;
            double fts = 1/3.2808399;
            double yds = 1/1.0936133;

            //Превръщаме входната величина в метри

            if (input == "mm")
            {
                n = n * (mms);
            }
            else if (input == "cm")
            {
                n = n * (cms);
            }
            else if (input == "mi")
            {
                n = n * (mis);
            }
            else if (input == "in")
            {
                n = n * (incs);
            }
            else if (input == "km")
            {
                n = n * (kms);
            }
            else if (input == "ft")
            {
                n = n * (fts);
            }
            else if (input == "yd")
            {
                n = n * (yds);
            }

            // умножаваме метрите (в горния if) по изходната величина


            if (output == "mm")
            {
                n = n / (mms);
            }
            else if (output == "cm")
            {
                n = n / (cms);
            }
            else if (output == "mi")
            {
                n = n / (mis);
            }
            else if (output == "in")
            {
                n = n / (incs);
            }
            else if (output == "km")
            {
                n = n / (kms);
            }
            else if (output == "ft")
            {
                n = n / (fts);
            }
            else if (output == "yd")
            {
                n = n / (yds);
            }

            Console.WriteLine(n + " " + output);
        }
    }
}
