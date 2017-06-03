using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12_EqualPairs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oldSum = 0;
            double sum = 0;
            double diff = 0;
            double maxdiff = double.MinValue;

            for (int i = 1; i <= 2 * n; i += 2)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                sum = a + b;
                oldSum = sum;
            

            if (i > 1 && oldSum != sum)
            {
                diff = Math.Abs(sum - oldSum);
                if (Math.Abs(diff) > Math.Abs(maxdiff))
                {
                    maxdiff = diff;
                }
                Console.WriteLine("No, maxdiff=" + diff);
            }
            else
            {
                Console.WriteLine("Yes, value=" + sum);
            }
            }
        }

    }
}
