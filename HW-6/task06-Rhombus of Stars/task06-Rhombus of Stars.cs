using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));

                for (int j = n - row; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(new string(' ', n - row));
                Console.WriteLine();
            }


            for (int row = 1; row < n; row++)
            {
                Console.Write(new string(' ', row));
                for (int j = row; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(new string(' ', row));
                
            }
        }
    }
}
