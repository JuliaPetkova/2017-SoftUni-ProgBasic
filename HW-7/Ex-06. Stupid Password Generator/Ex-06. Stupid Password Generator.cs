using System;
namespace Stupid_Password_Generator_6_March_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());

            // паролата се състои от 5 k-елемента (k1,k2,k3,k4,k5)

            for (int k1 = 1; k1 <= n; k1++)
            {
                for (int k2 = 1; k2 <= n; k2++)
                {
                    for (var k3 = 'a'; k3 < 'a' + L; k3++)
                    {
                        for (var k4 = 'a'; k4 < 'a' + L; k4++)                            
                        {
                            for (int k5 = Math.Max(k1, k2) + 1; k5 <= n; k5++)
                            {
                                Console.Write($"{k1}{k2}{k3}{k4}{k5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}