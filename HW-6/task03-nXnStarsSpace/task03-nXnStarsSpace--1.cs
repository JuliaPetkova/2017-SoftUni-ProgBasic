using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03_nXnStarsSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)           // n-реда
            {
                Console.Write("*");                     // * първата звездичка
                for (int col = 1; col < n; col++)   // цикъл за останалите " *" символи; започва от втория -->col=1
                {
                    Console.Write(" *");
                }
                Console.WriteLine();                    //wka 
            }
        }
    }
}