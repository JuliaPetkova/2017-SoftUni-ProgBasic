using System;


namespace task02_NumbersEndedTo__7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                if ((i % 10) == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
