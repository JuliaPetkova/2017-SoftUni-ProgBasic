using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());

            string opetator = Console.ReadLine();// „+“, „-“, „*“, „/“, „%“

            if (opetator == "+")
            {
                var result = (N1 + N2);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", N1, N2, result);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, result);
                }
            }
            else if (opetator == "-")
            {
                var result = (N1 - N2);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", N1, N2, result);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, result);
                }
            }
            else if (opetator == "*")
            {
                var result = (N1 * N2);
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", N1, N2, result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, result);
                }
            }
            else if (opetator == "/")
            {
                double result = (N1 / N2);
                if (N2 != 0)
                {
                    Console.WriteLine("{0} / {1} = {2:F2}", N1, N2, result);// със закръгление до 2 знак
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }

            }
            else if (opetator == "%")
            {
                var result = (N1 % N2);
                
                if (N2 != 0)
                {
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
            }
        }
    }
}

