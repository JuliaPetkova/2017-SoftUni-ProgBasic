using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = a / 13f;
            Console.WriteLine(b);

            // var delene = a / 3.0;
            // var delene = a / 3f; 
            //"f" = float; "m"  = decimal; L = long; 
            // делено на 3 - отрязва останалите цифри след десет. запетая
            // делено на 3.0 - резултат е дробно число и то е double, a ne float!!!

            byte byteN = 6;
            int intN = 20;

            var result = (byteN + intN);

            Console.WriteLine(result);

        }
    }
}
