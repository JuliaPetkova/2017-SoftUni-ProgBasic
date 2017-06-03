using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < (2 * n); i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (sum>)
                {
                    leftSum += inputNumber;
                }
                else
                {
                    rightSum += inputNumber;
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine("Yes, sum = {0}", leftSum);
                }
                else
                {
                    int dif = Math.Abs(leftSum - rightSum);
                    Console.WriteLine("No, dif = {0}", dif);
                }

            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                int dif = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, dif = {0}", dif);
            }
        }
    }
}

