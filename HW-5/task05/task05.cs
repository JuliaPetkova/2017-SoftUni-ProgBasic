using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    class task05
    {
        static void Main(string[] args)
        {
            Console.Write("Input n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Input next:");
                int inputNumber = int.Parse(Console.ReadLine());
                sum = sum + inputNumber;
            }
            Console.WriteLine(sum);

            DateTime d = new DateTime(2009, 10, 23, 15, 30, 22);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
            Console.WriteLine("{0:d.MM.yy г.}", d);
            //   23/10/2009 15:30:22
            //   23 / 10 / 09 г.
        }
    }
}
