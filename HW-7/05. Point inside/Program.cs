﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Point_inside
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool pointInsideRec1 = (x >= 4 && x <= 10) && (y <= 3 && y >= -5);
            bool pointInsideRec2 = (x >= 2 && x <= 12) && (y <= 1 && y >= -3);


            if (pointInsideRec1 || pointInsideRec2)
            {
                Console.WriteLine("in");
            }

            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
