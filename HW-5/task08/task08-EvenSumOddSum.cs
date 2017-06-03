using System;

namespace task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int EvenSum = 0;
            int OddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + number;
                }
                else
                {
                    OddSum = OddSum + number;
                }
            }
            
            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes, sum = {0}", EvenSum);
            }
            else
            {
                int dif = Math.Abs(EvenSum - OddSum);
                Console.WriteLine("No, diff = {0}", dif);
            }
        }
        
    }
}
