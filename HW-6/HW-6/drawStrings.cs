using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class drawStrings
    {
        static void Main(string[] args)
        {
            //   5 реда x 10 колони със "*"
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 10; col++)
                {
                    Console.Write("*"); // Внимава се за Write (не WriteLine)
                }
                Console.WriteLine();
            }



            Console.WriteLine(); Console.WriteLine();
            //    Друг запис 5 реда x 10 колони със "*"
            for (int row = 0; row < 5; row++)
            {
                Console.WriteLine(new string('*',10));
            }



            Console.WriteLine(); Console.WriteLine();
            //   ****--****
            for (int i = 0; i < 5; i++)
            {
                Console.Write(new string('*', 4));
                Console.Write(new string('-', 2));
                Console.WriteLine(new string('*', 4)); // след последния символ се добавя ред Console.WriteLine
            }


            Console.WriteLine(); Console.WriteLine();
            //   друг запис ****--****
            for (int i = 0; i < 5; i++)
            {
                string stars = new string('*', 4);
                string daches = new string('-', 4);

                //Console.WriteLine("{0}{1}{0}", stars, daches, stars);

                Console.WriteLine($"{stars}{daches}{stars}");           // чрез $ съдържаниео на плейсхолдера се приема като "променлива" или изчисление
            }

            Console.WriteLine(); Console.WriteLine();
            //   друг запис ****--****
            for (int i = 0; i < 5; i++)
            {
                string stars = new string('*', 4);
                string daches = new string('-', 4);
                Console.WriteLine($"{stars}{daches}{stars}{daches.Length + 100}");      // след ****--**** се добавя изчисление
            }

        }
    }
}
