using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nP1 = 0;          // брой числа, по-малки от 200
            int nP2 = 0;          // 200 - 399
            int nP3 = 0;          // 400 - 599
            int nP4 = 0;          // 600 - 799
            int nP5 = 0;          // >=800

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num<200)
                {
                    nP1 = nP1 + 1;
                }
                else if (num >= 200 && num<400)
                {
                    nP2 = nP2 + 1;
                }
                else if (num >= 400 && num < 600)
                {
                    nP3 = nP3 + 1;
                }
                else if (num >= 600 && num < 800)
                {
                    nP4 = nP4 + 1;
                }
                else
                {
                    nP5 = nP5 + 1;
                }
               

            }
            //Console.WriteLine("{0:P}", 0.345678); === 34.57%
            // github askata992
            Console.WriteLine("{0:P}", (double)nP1 / n);
            Console.WriteLine("{0:P}", (double)nP2 / n);
            Console.WriteLine("{0:P}", (double)nP3 / n);
            Console.WriteLine("{0:P}", (double)nP4 / n);
            Console.WriteLine("{0:P}", (double)nP5 / n);
        }
    }
}