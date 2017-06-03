using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p20_Recolta
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine()); // кв.м е лозе
            double Y = double.Parse(Console.ReadLine()); // kg грозде  за 1 кв.м 
            double Z = double.Parse(Console.ReadLine()); //необх литри
            int workers = int.Parse(Console.ReadLine()); // бр. работници

            double Rec = X * Y;
            double WineRec = (Rec * 40) / 100;
            double Litters = WineRec / 2.5;
            double rest = (Litters - Z);

            if (rest <= 0)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Abs(Math.Truncate(rest)));
            }
            else if (rest > 0)
            {
                double l = rest / workers;
                Console.WriteLine("Good harvest this year!Total wine: {0} liters.", Math.Truncate(Litters));
                Console.WriteLine("{0:0} liters left -> {1:0} liters per person.", rest, l);
            }

        }
    }
}
