using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_koordinati
{
    class Program
    {
        static void Main(string[] args)
        {
            // Важно е да се зададат във вярната последователност координатите иначе няма да
            // се получи лицето (перимеръра винаги се получава)

            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());


            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);

            Console.WriteLine("S = " + (a * b));
            Console.WriteLine("P = " + (a + b) * 2);
        }
    }
}
