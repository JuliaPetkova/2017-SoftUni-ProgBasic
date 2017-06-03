using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());




            int slash = (2 * n) - 2;
            int stars = 1;
            int line = n;
            int spaces = n;



            // първи/последен ред
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));



            //if (n % 2 == 0)
            //{
            //    for (int i = 0; i < n / 2 - 2; i++)
            //    {
            //        Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < n / 2 - 1; i++)
            //    {
            //        Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
            //    }
            //}

            //Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string('|', n));

            //for (int i = 0; i < n / 2 - 1; i++)
            //{
            //    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
            //}



            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2)
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', stars), new string('/', slash), new string('|', line));
                else
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', stars), new string('/', slash), new string(' ', spaces));

            }


            // първи/последен ред
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));

        }
    }
}