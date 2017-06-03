using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07_2n_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                leftSum = leftSum + number;
            }

            for (int i = n + 1; i <= 2 * n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSum = rightSum + number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum); // аргумента може да е и rightSum
            }
            else
            {
                var diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
