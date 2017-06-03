using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ConsoleApp2
    {
        public static void Main(string[] args)
        {

            int m = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + m; i++)
            {
                Console.Write($"{i} ");

            }

        }
    }
}