﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03_nXnStarsSpace_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
