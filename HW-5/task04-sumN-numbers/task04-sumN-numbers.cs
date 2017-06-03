using System;

namespace task04_sumN_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //когато имаме SUM, инициализираме с 0, 
            //когато имаме MAX - инициализираме с min стойност
            //когато имаме MIN - инициализираме с max стойност

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                
            }
            Console.WriteLine(sum);
        }
    }
}
