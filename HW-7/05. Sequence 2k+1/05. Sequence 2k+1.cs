using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;

            for (int i = 0; i <= n; i++)
            {
                
                if (k <= n)
                {
                    Console.WriteLine(k);
                    k = 2 * k + 1;
                }

            }
        }
    }
}
