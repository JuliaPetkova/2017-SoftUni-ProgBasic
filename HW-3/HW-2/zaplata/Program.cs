using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaplata
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());// дни/ месец
            double M = double.Parse(Console.ReadLine()); // USD/ден
            double UsdBgn = double.Parse(Console.ReadLine()); // курс на долара

            double salary = (M * N * 14.5) * UsdBgn;
            double sal = ((salary - (salary * 0.25) )/365);
            Console.WriteLine(Math.Round(sal,2));
        }
    }
}
