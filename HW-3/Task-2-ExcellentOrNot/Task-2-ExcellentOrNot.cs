using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            double Result = double.Parse(Console.ReadLine());

            if (Result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
