using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_таск_Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var TriArea = (a * b) / 2;
            Console.Write("Triangle area = ");
            Console.WriteLine(Math.Round(TriArea, 2));

        }
    }
}
