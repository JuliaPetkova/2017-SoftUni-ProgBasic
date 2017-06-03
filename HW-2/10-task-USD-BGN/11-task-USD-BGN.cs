using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_USD_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = (1.79549 * USD);

            Console.WriteLine("{0} BGN", Math.Round(BGN, 2));
        }
    }
}
