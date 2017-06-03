using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //преписана
            int n = int.Parse(Console.ReadLine());
            int oldSum = 0;
            int sum = 0;
            int diff = 0;

            for (int i = 1; i <= n * 2; i += 2) 
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;

                if (i > 1 && oldSum != sum)
                             // защо се проверява за i>1 --> защото при i=1 няма стара сума
                             // защо сметките по-долу не са в 
                            //{
                            //}

                diff = Math.Abs(sum - oldSum);
                oldSum = sum;
            }

            if (diff == 0)
            {
                Console.WriteLine("Yes, value=" + sum);
            }
            else             ///не трябва ли да дефинираме maxdiff
            {
                Console.WriteLine("No, maxdiff=" + diff);
            }

        }
    }
}