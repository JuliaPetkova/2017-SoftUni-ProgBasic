using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08.Factorial_FOR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factor = 1; // Важно е да се инициализира от 1!

            for (int i = 1; i <= n; i++)
            {
                factor = factor * i;
            }
            Console.WriteLine(factor);
        }
    }
}
