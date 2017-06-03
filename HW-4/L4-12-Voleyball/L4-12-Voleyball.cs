using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_12_Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string LeapNormal = Console.ReadLine(); // visokosna godina
            int p = int.Parse(Console.ReadLine());// br. Hollidays
            int h = int.Parse(Console.ReadLine());// br. dni na Selo

            double inSofia = (48 - h) * (3.0 / 4);
            double inSelo = h;
            double inHolidays = p * 2.0 / 3;
            double sum = inSofia + inSelo + inHolidays;

            if (LeapNormal == "normal")
            {
                Console.WriteLine(Math.Truncate(sum));
            }
            else if (LeapNormal == "leap")
            {
                Console.WriteLine(Math.Truncate(sum + (sum * 15.0) / 100));
            }
        }
    }
}
