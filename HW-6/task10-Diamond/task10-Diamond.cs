using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int OddOutDashes = (int)Math.Ceiling((n - 1) / 2.0);
            int EvenOutDashes = (int)Math.Ceiling((n - 2) / 2.0);


            int j = (int)Math.Ceiling((n - 2) / 2.0); // брой редове горе
            int k = n - j;    // брой редове долу

            // First/Last row

            if (n % 2 != 0 && n > 2)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
            }
            else if (n % 2 == 0 && n > 2)
            {
                Console.WriteLine("{0}**{0}", new string('-', (n - 2) / 2));
            }

            // inside rows -->


            if (n % 2 != 0)
            {
                int inside = 1;


                for (int i = 1; i <= j; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', (int)OddOutDashes - i), new string('-', inside));
                    inside = inside + 2;
                }
            }
            else
            {
                int inside = 2;

                for (int i = 1; i <= Math.Ceiling((n - 2) / 2.0); i++)
                {

                    Console.WriteLine("{0}*{1}*{0}", new string('-', (int)EvenOutDashes - i), new string('-', inside));
                    inside = inside + 2;
                }
            }

            // inside rows <--


            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', i), new string('-', (n - (2 + 2 * i))));

            }
            // First/Last row

            if (n % 2 != 0)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
            }
            else
            {
                Console.WriteLine("{0}**{0}", new string('-', (n - 2) / 2));
            }
        }
    }
}

