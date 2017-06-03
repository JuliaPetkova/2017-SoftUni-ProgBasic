using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a = ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("input b = ");
            var b = int.Parse(Console.ReadLine());

            var sum = a + b;
            Console.WriteLine("suma = " + sum);
        }
    }
}
