using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_06.MagicNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++) // може също i = 100000
            {
                // инициализираме произведението rezult и числото, чиито цифри ще умножаме
                int result = 1;
                int num = i;

                while (num > 0)
                {
                    result = result * (num % 10);   // умножаваме всяка цифра на num
                    num = num / 10;                 //
                }

                if (result == magicNum)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
