using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // инициализация
            int currentNumber = 1;

            while (currentNumber <= n) //check
            {
                // body
                Console.WriteLine(  currentNumber);
                // increment counter
                currentNumber = 2*currentNumber +1;
            }

        }
    }
}
