using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int count = 1;

            while (true)
            {
                if (n > count && n % count == 0)
                {
                    Console.WriteLine("Not prime");
                    break;
                }
                else if (n == 1 || n == 0)
                {
                    Console.WriteLine("Not prime");
                    break;
                }
                else if (n == 2 || n > count)
                {
                    Console.WriteLine("prime");
                    break;
                }
                else
                {
                    break;
                }
                count++;
            }
        }
    }
}

