using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int lenght = input.Length;
            int sum = 0;

            for (int i = 0; i < lenght; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}