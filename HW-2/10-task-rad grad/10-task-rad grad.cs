using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_rad_grad
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var grad = 180 * rad / (Math.PI);
                
            Console.WriteLine(Math.Round(grad, 0));

        }
    }
}
