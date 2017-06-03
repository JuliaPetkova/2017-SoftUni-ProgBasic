using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13_STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n;
            int dashes = 2 * n;

            // first row
            Console.WriteLine("{0}{1}{0}", new string(' ', spaces + 1), new string('_', dashes + 2));

            // upper rows
            for (int i = 0; i < n; i++)
            {
                int UpperSpace = spaces - i;
                int UpperDashes = dashes + 2 * i;
                Console.WriteLine("{0}//{1}{2}\\{0}", new string(' ', UpperSpace), new string('_', UpperDashes), "\\");

            }

            // middle row
            int MidSpace = (5 * n - 5) / 2;
            Console.WriteLine("//{0}{1}{0}{2}\\", new string('_', MidSpace), "STOP!", "\\");

        }

    }
}
