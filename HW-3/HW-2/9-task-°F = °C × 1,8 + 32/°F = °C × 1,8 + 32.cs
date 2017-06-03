using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_task__F____C___1_8___32
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = float.Parse(Console.ReadLine());

            var F = C * 1.8 + 32;
            Console.WriteLine(Math.Round(F, 2));
        }
    }
}
