using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01.Numbers_1._._.N_with_Step_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i=i+3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
