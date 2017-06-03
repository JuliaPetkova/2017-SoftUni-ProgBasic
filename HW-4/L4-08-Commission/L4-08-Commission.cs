using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_08_Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double volume = double.Parse(Console.ReadLine());

            if (volume < 0)
            {

                Console.WriteLine("error");
                return;
            }

            if (town == "sofia")
            {
                if (volume >= 0 && volume <= 500)
                {
                    Console.WriteLine("{0:f2}", volume * 5 / 100);
                }

                else if (volume > 500 && volume <= 1000)
                {
                    Console.WriteLine("{0:f2}", volume * 7 / 100);
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    Console.WriteLine("{0:f2}", volume * 8 / 100);
                }
                else if (volume > 10000)
                {
                    Console.WriteLine("{0:f2}", volume * 12 / 100);
                }
            }
            else if (town == "varna")
            {
                if (volume >= 0 && volume <= 500)
                {
                    Console.WriteLine("{0:f2}", volume * 4.5 / 100);
                }

                else if (volume > 500 && volume <= 1000)
                {
                    Console.WriteLine("{0:f2}", volume * 7.5 / 100);
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    Console.WriteLine("{0:f2}", volume * 10 / 100);
                }
                else if (volume > 10000)
                {
                    Console.WriteLine("{0:f2}", volume * 13 / 100);
                }
            }
            else if (town == "plovdiv")
            {
                if (volume >= 0 && volume <= 500)
                {
                    Console.WriteLine("{0:f2}", volume * 5.50 / 100);
                }

                else if (volume > 500 && volume <= 1000)
                {
                    Console.WriteLine("{0:f2}", volume * 8.00 / 100);
                }
                else if (volume > 1000 && volume <= 10000)
                {
                    Console.WriteLine("{0:f2}", volume * 12.00 / 100);
                }
                else if (volume > 10000)
                {
                    Console.WriteLine("{0:f2}", volume * 14.50 / 100);
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
