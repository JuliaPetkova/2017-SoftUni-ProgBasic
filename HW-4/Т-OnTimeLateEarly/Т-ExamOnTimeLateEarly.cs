using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т_OnTimeLateEarly
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int hourS = int.Parse(Console.ReadLine());
            int minS = int.Parse(Console.ReadLine());

            var Min = hour * 60 + min; // Входът превръщам в минути
            var Mins = hourS * 60 + minS;

            var time = (Mins - Min); // Разликата във времето (отрицателна - рано; положителна - закъснял)

            var hh = Math.Abs(time / 60); // намирам часовете и
            var mm = Math.Abs(time % 60); // минутите


            if (time <= 0 && time >= -30)
            {
                Console.WriteLine("On time");

                if (time < 0)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(time));
                }

            }

            else if (time < -30)
            {
                Console.WriteLine("Early");
                if (time < -30 && time > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(time));
                }
                else if (time <= -60)
                {
                    if (mm < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours before the start", hh, mm);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hh, mm);
                    }
                }

            }
            else
            {
                Console.WriteLine("Late");
                if (time > 0 && time < 60)
                {
                    Console.WriteLine("{0} minutes after the start", time);
                }
                else if (time >= 60)
                {
                    if (mm < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hh, mm);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hh, mm);
                    }

                }
            }
        }
    }
}
