using System;


namespace task06
{
    class task06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (min > number)
                {
                    min = number;
                }

            }
            Console.WriteLine(min);
        }
    }
}

