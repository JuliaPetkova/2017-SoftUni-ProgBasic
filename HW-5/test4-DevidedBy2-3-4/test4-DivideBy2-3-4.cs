using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4_DevidedBy2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double nP1 = 0;  // инициализация с 0, защото ще сумираме броя "num", делящи се на 2
            double nP2 = 0;  // на 3
            double nP3 = 0;  // на 4


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    nP1 = nP1 + 1;
                }
                if (num % 3 == 0)
                {
                    nP2 = nP2 + 1;
                }
                if (num % 4 == 0)
                {
                    nP3 = nP3 + 1;
                }
            }
            Console.WriteLine("{0:F2}%", (nP1 / n) * 100);
            // не става с "{0:P}", защото добавя интервал "33,56 %"
            Console.WriteLine("{0:F2}%", (nP2 / n) * 100);
            Console.WriteLine("{0:F2}%", (nP3 / n) * 100);
        }
    }
}
