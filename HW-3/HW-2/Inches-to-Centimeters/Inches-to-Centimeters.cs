using System;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.Write("Input inches = ");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Centemeters = " + (a*2.54));
        }
    }
}
