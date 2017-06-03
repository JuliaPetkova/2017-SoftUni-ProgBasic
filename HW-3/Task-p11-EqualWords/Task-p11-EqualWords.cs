using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p11_EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word1 = Console.ReadLine();
            string Word2 = Console.ReadLine();

            Word1 = Word1.ToLower();
            Word2 = Word2.ToLower();

            if (Word1 == Word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
