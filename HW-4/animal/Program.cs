using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mamal");
                    break;

                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptil");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
