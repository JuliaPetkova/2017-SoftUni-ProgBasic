using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int F0 = 1;
            int F1 = 1;

            if (n == 0 || n == 1)
            {
                sum = 1;
            }
            for (int i = 0; i < n-1; i++)
            {
                sum = F1 + F0;
                F0 = F1;
                F1 = sum;
            }
            Console.WriteLine(sum);

        }
    }
}
