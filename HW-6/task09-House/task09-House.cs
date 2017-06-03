using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09_House
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int OddStars = 1;  // първия ред при нечетните е "*"
            int EvenStars = 2; // при четните е "**"


            // покрив
            for (int i = 1; i <= Math.Ceiling(n / 2.0); i++)    //редовете на покрива се закръгляват към горното число
            {
                if (n % 2 != 0)     
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - OddStars) / 2), new string('*', OddStars));

                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - EvenStars) / 2), new string('*', EvenStars));
                }
                OddStars = OddStars + 2;
                EvenStars = EvenStars + 2;
            }


            // стени

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", "|", new string('*', n - 2));
            }


        }
    }
}
