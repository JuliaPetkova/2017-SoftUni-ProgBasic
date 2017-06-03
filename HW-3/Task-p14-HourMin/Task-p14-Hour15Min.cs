using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p14_HourMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hours = int.Parse(Console.ReadLine());
            int Minutes = int.Parse(Console.ReadLine());

            Minutes = Minutes + 15;

            if (Minutes > 59)
            {
                Hours = Hours + (Minutes / 60);
                Minutes = Minutes % 60;
                if (Minutes < 10)
                {
                    if (Hours > 23)
                    {
                        Hours = Hours - 24;
                    }
                    Console.WriteLine("{0}:0{1}", Hours, Minutes);
                }
                else
                {
                    if (Hours > 23)
                    {
                        Hours = Hours - 24;
                    }
                    Console.WriteLine("{0}:{1}", Hours, Minutes); // "{0:{1:00)}"
                }
            }
            else
            {
                if ((Minutes) < 10)
                {
                    if (Hours > 23)
                    {
                        Hours = Hours - 24;
                    }
                    Console.WriteLine("{0}:0{1}", Hours, Minutes);
                }
                else
                {
                    if (Hours > 23)
                    {
                        Hours = Hours - 24;
                    }
                    Console.WriteLine("{0}:{1}", Hours, Minutes);
                }
            }
        }
    }
}
