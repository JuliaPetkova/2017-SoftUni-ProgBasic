using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variantiStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int startStars = 2 - n % 2;
            int topRows = (n + 1) / 2;
            int kowRows = n - topRows;


            // top row
            for (int i = 0; i < topRows; i++)
            {
                int startDashes = (n - startStars) / 2;
                Console.Write(new string('-', startDashes));
                Console.Write(new string('*', startStars));
                Console.WriteLine(new string('-', startDashes));
            }

            // top other rows
            for (int i = 0; i < topRows; i++)
            {

                Console.Write(new string('-', startStars+i*2));
                Console.WriteLine(new string('-', startDashes));
            }

            //low rows


        }
    }
}
