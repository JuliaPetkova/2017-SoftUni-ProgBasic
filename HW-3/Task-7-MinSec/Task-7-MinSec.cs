using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_MinSec
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());

            int sum = (t1 + t2 + t3);
            
            int min = (sum / 60);

            int sec = sum % 60;

            if (sec<10)
            {
                Console.WriteLine("{0}:0{1}", min, sec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min, sec);
            }
        }
    }
}
