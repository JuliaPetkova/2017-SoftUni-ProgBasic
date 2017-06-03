using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime input = DateTime.Now;
            Console.WriteLine(input.AddDays(999).ToShortDateString());
        }
    }
}
