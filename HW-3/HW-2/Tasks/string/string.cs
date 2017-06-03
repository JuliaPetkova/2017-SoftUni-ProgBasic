using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            var ime = Console.ReadLine();

            Console.WriteLine(ime + 5 + 5); //долепва ги
            Console.WriteLine(ime + (5+5)); // първо в скобите сбор, после го долепя
        }
    }
}
