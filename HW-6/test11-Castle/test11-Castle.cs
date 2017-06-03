using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11_Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // first row
            if (n < 5)
            {
                Console.WriteLine("/{0}\\/{0}\\", new string('^', n / 2));
            }
            else
            {
                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', n / 2));
            }


            // middle rows
            if (n < 5)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
                }
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    int inside = (2 * n) - 2;
                    Console.WriteLine("|{0}|", new string(' ', inside));
                }
                Console.WriteLine("| {0}{1}{0} |", new string(' ', n/2), new string('_', n/2));
            }



            // last row

            // first row
            if (n < 5)
            {
                Console.WriteLine("\\{0}/\\{0}/", new string('_', n / 2));
            }
            else
            {
                Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', n / 2));
            }


        }
    }
}
