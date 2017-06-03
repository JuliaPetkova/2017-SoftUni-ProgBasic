using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05_SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

                        // първи и последне ред са еднакви--> + - - - - +
                Console.Write("+");
                for (int i = 0; i < n - 2; i++)  // без първата и послената позиция
                {
                    Console.Write(" -");
                }
                Console.Write(" +");
                Console.WriteLine();


            // средните редове --> | - - - - |
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }

                    // първи и последне ред са еднакви--> + - - - - +
            Console.Write("+");
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();


        }
    }
}
