using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            Console.WriteLine(new string('*', n)); // 1-ви ред с n-броя *-чки

            for (int k = 0; k < (n - 2); k++)
            {
                Console.WriteLine("{0}{1}{2}", new string('*', 1), new string(' ', n - 2), new string('*', 1));
            }
            Console.WriteLine(new string('*', n));        // последен ред с n-броя *-чки             
        }
    }
}
