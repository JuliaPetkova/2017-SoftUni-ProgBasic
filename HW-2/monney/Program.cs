using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monney
{
    class Program
    {
        static void Main(string[] args)
        {
            double BEAT = double.Parse(Console.ReadLine());
            double UAN = double.Parse(Console.ReadLine());
            double com = double.Parse(Console.ReadLine()); // комисионна

            double eu = 1.95;
            double beat = BEAT * 1168;// lv 
            double uan = (0.15 * UAN) * 1.76;//lv
            
            double sum = beat / eu + uan / eu;

            double sum1 = sum - ((com / 100) * sum);

            Console.WriteLine(sum1);

        }
    }
}
