using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p18_PriceTransport
{
    class Program
    {
        static void Main(string[] args)
        {

            int km = int.Parse(Console.ReadLine());
            string dayORnight = Console.ReadLine();

            double taxi;
            double bus;
            double train;

            if (dayORnight == "day")
            {
                taxi = 0.7 + km * 0.79;
                Console.WriteLine(taxi);
            }
            else
            {
                taxi = 0.7 + km * 0.90;
                Console.WriteLine(taxi);
            }

            if (km >= 20 && km < 100)
            {
                bus = 0.09 * km;
                Console.WriteLine(Math.Min(taxi, bus));
            }
            else if (km >= 100)
            {
                bus = 0.09 * km;
                train = 0.06 * km;
                Console.WriteLine(Math.Min(train, Math.Min(taxi, bus)));
            }
        }
    }
}