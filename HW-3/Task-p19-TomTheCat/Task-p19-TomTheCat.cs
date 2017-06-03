using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p19_TomTheCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int Holidays = int.Parse(Console.ReadLine());
            var WorkDay = 365 - Holidays;

            var minWorkDays = 63 * WorkDay;
            var minHolidays = 127 * Holidays;
            var play = minHolidays + minWorkDays;

            if (play > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", ((play-30000) / 60), ((play-30000) % 60));
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", ((30000-play) / 60), ((30000-play) % 60));
            }
        }
    }
}
