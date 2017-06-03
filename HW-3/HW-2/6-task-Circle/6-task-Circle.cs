using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(r, 2);
            //var area = Math.PI * r * r;

            var perimeter = 2 * Math.PI * r;

            Console.Write("Area = ");
            Console.WriteLine(area);

            Console.Write("Perimeter = ");
            Console.WriteLine(perimeter);
        }
    }
}
