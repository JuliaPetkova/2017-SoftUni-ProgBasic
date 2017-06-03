using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т-OperationWithNumbers
{
    class Program
{
    static void Main(string[] args)
    {
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());

        string opetator = Console.ReadLine();// „+“, „-“, „*“, „/“, „%“

        if (opetator == "+")
        {
            var result = (N1 + N2);
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} + {1} = {2} – even", N1, N2, result);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2} – odd", N1, N2, result);
            }
        }
        else if (opetator == "-")
        {
            var result = (N1 - N2);
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} - {1} = {2} – even", N1, N2, result);
            }
            else
            {
                Console.WriteLine("{0} - {1} = {2} – odd", N1, N2, result);
            }
        }
        else if (opetator == "*")
        {
            var result = (N1 * N2);
            if (result % 2 == 0)
            {
                Console.WriteLine("{0} * {1} = {2} – even", N1, N2, result);
            }
            else
            {
                Console.WriteLine("{0} * {1} = {2} – odd", N1, N2, result);
            }
        }
        else if (opetator == "/")
        {
            var result = (N1 / N2);
            if (N2 != 0)
            {
                Console.WriteLine("{0} / {1} = {2:f2}", N1, N2, result);// със закръгление до 2 знак
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", N1);
            }

        }
        else if (opetator == "%")
        {
            var result = (N1 % N2);
            Console.WriteLine("{0} % {1} = {2}", N1, N2, result);
        }
    }
}
}
