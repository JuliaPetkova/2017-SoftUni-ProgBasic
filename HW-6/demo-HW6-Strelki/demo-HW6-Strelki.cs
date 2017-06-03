using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_HW6_Strelki
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -5; i < 5; i++)
            {
                Console.WriteLine(new string('*', Math.Abs(i))); // i e 5 4 3 2 1 0 1 2 3 4 5 
            }
        }
    }
}
