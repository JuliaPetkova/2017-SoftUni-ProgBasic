using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_06.MagicNumbers__2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int k1 = 1; k1 <= 9; k1++)
            {
                for (int k2 = 1; k2 <= 9; k2++)
                {
                    for (int k3 = 1; k3 <= 9; k3++)
                    {
                        for (int k4 = 1; k4 <= 9; k4++)
                        {
                            for (int k5 = 1; k5 < 9; k5++)
                            {
                                for (int k6 = 1; k6 < 9; k6++)
                                {
                                    if (k1 * k2 * k3 * k4 * k5 * k6 == n)
                                    {
                                        Console.Write($"{k1}{k2}{k3}{k4}{k5}{k6} ");
                                    }
                                }

                            }
                        }
                    }
                }

            }
        }
    }
}
