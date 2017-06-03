using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyAsen
{
    class Program
    {
        static void Main(string[] args)
        {
            // не може с тези типове на данните

            int bitcoins = int.Parse(Console.ReadLine());
            decimal ioana = decimal.Parse(Console.ReadLine());
            decimal komisionna = decimal.Parse(Console.ReadLine());

            decimal leva = bitcoins * 1168;
            decimal usd = ioana * 0.15m;
            leva = leva + usd * 1.76m;

            decimal euro = leva / 1.95m;

            decimal result = euro - (euro * komisionna / 100);

            Console.WriteLine(result);
        }
    }
}
