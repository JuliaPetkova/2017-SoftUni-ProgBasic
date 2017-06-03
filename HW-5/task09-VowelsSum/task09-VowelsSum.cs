using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task33
{
    class task09
    {
        static void Main(string[] args)
        {
            // защо принтира резултата от всяка проверка, като последния е верен?
            // защо гърми като направя i = 1; i<= str.Lenght

            string str = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < str.Length; i++) //дава дължината на стринга str.Lenght
            {
                switch (str[i])
                // str[i] взема от стринга всяка буква
                {
                    case 'a':
                        sum = sum + 1;
                        break;

                    case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum = sum + 3;
                        break;
                    case 'o':
                        sum = sum + 4;
                        break;
                    case 'u':
                        sum = sum + 5;
                        break;

                    default:
                        break;
                        
                }
                Console.WriteLine(sum);
            }
           
        }

    }
}
