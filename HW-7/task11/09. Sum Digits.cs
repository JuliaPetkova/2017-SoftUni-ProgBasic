using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                int k = n % 10;
                sum = sum + k;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
