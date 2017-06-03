using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12__EqualPairs_Julia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oldSum = 0;
            int sum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 1; i <= 2 * n; i += 2)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());

                sum = num1 + num2;
                diff = Math.Abs(sum - oldSum);
                sum = oldSum;

                if (diff > maxDiff)
                {  maxDiff = diff;
                Console.WriteLine("No, maxdiff=" + maxDiff);}
                   
            
            else
            
                Console.WriteLine("Yes, value=" + sum);

            }





        }
    }
}
