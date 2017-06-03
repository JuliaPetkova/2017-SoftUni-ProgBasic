using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_plochki
{
    class Repair_plochki
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); // страна на площадка

            double w = double.Parse(Console.ReadLine()); // ширина плочка
            double l = double.Parse(Console.ReadLine()); // дължина плочка

            double m = double.Parse(Console.ReadLine()); // ширина пейка
            double o = double.Parse(Console.ReadLine()); // дължина пейка

            var s = Math.Pow(n,2);  // Лице на площадката
            var s1 = s - (m * o);  // Лице на площадка без пейка

            var N = s1 / (w * l); // брой плочки 
            Console.WriteLine(N);

            var t = N * 0.2; // времето за поставяне на плопчките
            Console.WriteLine(t);
            
        }
    }
}
