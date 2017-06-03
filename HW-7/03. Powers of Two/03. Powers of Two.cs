using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                double PowersOfTwo = Math.Pow(2, i);
                Console.WriteLine(PowersOfTwo);
            }
        }
    }
}
