using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace таск04_TriangleofDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write("$");               // всеки ред започва със & и продължава " $"--->
                for (int col = 2; col <= row; col++) // за "триъгълник", col < row
                {
                    Console.Write(" $");

                }
                Console.WriteLine();
            }


        }

    }

}

