using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_i
{
    class urok
    {
        static void Main(string[] args)
        {
            //// веднъж се обявява типа на 
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (i = 1; i < 5; i++)
            //    {
            //    }
            //}

            var a = 5;
            Console.WriteLine(a + a);

            var b = '5';
            Console.WriteLine(b + b);

            var c = "5";
            Console.WriteLine(c + c);

            byte n = 1;
            int m = 2;

            //var s = (byte)(m + n); // различни начини на кон
            var s = Convert.ToChar(m + n);

            Console.WriteLine(s);

            Console.WriteLine(s.GetType());


        }

    }
}
