﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // да се отпечатат числата от 1 до 10
            //Console.WriteLine(1); // реално се изпълнява командата: Console.WriteLine(1.ToString());

            // Първи начин:
            int p = 1;
            while (p <= 10)
            {
                Console.WriteLine(p);
                p++;
            }

            // добавям празен ред
            Console.WriteLine();

            // Втори начин:

            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine(i);
            }


            Console.WriteLine("{0:C2}", 123.456);
            //Output: 123,46 лв.

            Console.WriteLine("{0:D6}", -1234);
            //Output: -001234

            Console.WriteLine("{0:F2}", -123.456);
            //Output: -123,46

            Console.WriteLine("{0:N2}", 1234567.8);
            //Output: 1 234 567,80

            Console.WriteLine("{0:P}", 0.456);
            //Output: 45,60 %

            Console.WriteLine("{0:X}", 254);
            //Output: FE

            Console.WriteLine("{0:0.00}", 1);
            //Output: 1,00

            Console.WriteLine("{0:#.##}", 0.234);
            //Output: ,23

            Console.WriteLine("{0:#####}", 12345.67);
            //Output: 12346

            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
            //Output: (02) 934 25 25

            Console.WriteLine("{0:%##}", 0.234);
            //Output: %23
        }
    }
}

