﻿using System;
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

            // 1. първи/последен ред
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));


            //1.   ********   ********
            //2.   *//////*||||*//////*
            //2.   *//////*    *//////*
            //1.   ********   ********

            // 2. средни редове
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2.0) // Math.Floor((n - 1) / 2.0))
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", "*", new string('/', (2 * n) - 2), new string('|', n));
                else
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", "*", new string('/', (2 * n) - 2), new string(' ', n));

            }


            //1. първи/последен ред
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));

        }
    }
}