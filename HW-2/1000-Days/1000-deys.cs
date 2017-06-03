using System;
using System.Collections.Generic;
using System.Globalization; // добавих това

namespace _13_task_1000_days
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            Console.WriteLine((Convert.ToDateTime(date).AddDays(999).ToShortDateString()));

        }
    }
}
