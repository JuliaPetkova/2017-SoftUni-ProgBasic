﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(counter);
                    Console.Write(" ");
                    counter++;
                    if (counter > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (counter > n)
                {
                    break;
                }
            }
        }
    }
}
