using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p18_Basein
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var v1 = P1 * h;
            var v2 = P2 * h;

            if ((V - (v1 + v2)) >= 0)
            {
                var vPr = Math.Truncate(((v1 + v2) / V) * 100);
                var vPr1 = Math.Truncate((v1 / (v1 + v2)) * 100);
                var vPr2 = Math.Truncate((v2 / (v1 + v2) * 100));

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", vPr, vPr1, vPr2);
            }
            else
            {
                var vOver = V - ((P1 + P2) * h);

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, Math.Abs(vOver));
            }

        }
    }
}
