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

            int startStars = 2 - n % 2;   // Хитрост! 1 или 2 звезди са на първия ред
            Console.WriteLine(startStars);

            int topRows = (n + 1) / 2;    // вместо: (int)Math.Ceiling(n / 2.0) 
                                          // --> (n + 1) / 2 (искаме горните редове да се закръглят към по-голямото число
            Console.WriteLine(topRows);
            int bottomRows = n - topRows;


            // top/bottom row

            Console.WriteLine("{0}{1}{0}", new string('-', (n - startStars) / 2), new string('*', startStars));


            // top all rows
            for (int i = 0; i < topRows-1; i++)
            {
                int insideDashes = startStars + 2*i;
                int dashes = (n - 2 - insideDashes) / 2;
                Console.WriteLine("{0}*{1}*{0}", new string('-', dashes), new string('-', insideDashes));
            }


            // bottom rows -->

            for (int i = 0; i < bottomRows-1; i++)
            {
                int dashes = i+1;
                int insideDashes = startStars + 2 * i;
                
                Console.WriteLine("{0}*{1}*{0}", new string('-', dashes), new string('-', insideDashes));
            }
        }
    }
}
