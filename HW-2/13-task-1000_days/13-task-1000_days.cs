using System;
using System.Collections.Generic;
using System.Globalization; // добавих това

namespace _13_task_1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTR = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime date = DateTime.ParseExact(inputTR, format, CultureInfo.InvariantCulture);
            date = date.AddDays(999);

            Console.WriteLine(date.ToString(format));
        }
    }
}
