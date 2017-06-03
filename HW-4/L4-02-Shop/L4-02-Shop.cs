using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_02_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quontity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quontity * 0.5);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quontity * 0.8);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quontity * 1.2);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quontity * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quontity * 1.6);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quontity * 0.4);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quontity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quontity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quontity * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quontity * 1.5);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quontity * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(quontity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(quontity * 1.1);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(quontity * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(quontity * 1.55);
                }
            }
        }
    }
}
