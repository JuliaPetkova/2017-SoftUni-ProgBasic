using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task09_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            int count = 1;

            do
            {
                factorial = factorial * count;
                count++;

            } while (count <=n);

            Console.WriteLine(factorial);
        }
    }
}
