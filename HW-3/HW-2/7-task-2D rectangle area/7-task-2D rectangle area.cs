using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task_2D_rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // дефинираме точка 1 с нейните координати
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            // дефинираме точка 2 с нейните координати
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2); // дължината се взема по Абсолютна стойност (полож число)
            var b = Math.Abs(y1 - y2);
            
            double area = a * b;
            double perimetar = 2*(a + b);

        }
    }
}
