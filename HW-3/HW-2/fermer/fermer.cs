using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fermer
{
    class fermer
    {
        static void Main(string[] args)
        {
            var lv1 = double.Parse(Console.ReadLine()); // цена за 1 кг veg
            var lv2 = double.Parse(Console.ReadLine()); // цена за 1 кг fru

            var kg1 = double.Parse(Console.ReadLine());// kg
            var kg2 = double.Parse(Console.ReadLine());// kg

            double sum = ((lv1 * kg1) + (lv2 * kg2))/1.94;

            Console.WriteLine(sum);


        }
    }
}
