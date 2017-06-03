using System;

namespace task10_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue; // може само с int
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;

                if (max < number)
                {
                    max = number;
                }

            }

            if ((sum / 2) == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                var diff = Math.Abs(max - (sum-max)); // Тук внимание максималната - сумата на останалите
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
