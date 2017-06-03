using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task33
{
    class task33
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            //дава дължината на стринга str.Lenght
            {
                if (str[i] == 'a')
                {
                    sum = sum + 1;
                }
                else if (str[i] == 'e')
                {
                    sum = sum + 2;
                }
                else if (str[i] == 'i')
                {
                    sum = sum + 3;
                }
                else if (str[i] == 'o')
                {
                    sum = sum + 4;
                }
                else if (str[i] == 'u')
                {
                    sum = sum + 5;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
