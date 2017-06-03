using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("{0} = even", a);

            else if (a % 2 != 0)                   
            Console.WriteLine("{0} = odd", a);
        }
    }
}

