﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    class task06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <min)
                {
                    min = number;
                }

            }
            Console.WriteLine(min);

        }

    }

}

