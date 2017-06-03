using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sol = 0; // декларираме и инициализираме
            //int soli = Int32; // декларираме и инициализираме


            //var a = 5;
            //Console.WriteLine(a.GetType());
            //Console.WriteLine(a + a); // 10

            //var b = '5';
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(b + b); // 106 - AS

            //var c = '5';
            //Console.WriteLine(c.GetType());
            //Console.WriteLine(c + c); // 106

            ////
            //Console.WriteLine("Input int number:");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine(true);
            //    else
            //    Console.WriteLine(false);
            //}

            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - x2);

            Console.WriteLine();


            ///
            double = 5.5;

        }
    }
}
