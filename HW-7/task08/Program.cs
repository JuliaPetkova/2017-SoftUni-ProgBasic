using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            while (A % B != 0)
            {
                int temp = A % B;
                A = B;
                B = temp;
            }
            Console.WriteLine(B);
        }
    }
}
