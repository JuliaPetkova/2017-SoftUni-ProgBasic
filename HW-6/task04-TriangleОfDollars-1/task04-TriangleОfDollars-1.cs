using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04_TriangleОfDollars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= n; i++)
            {
                string dolars = "";
                for (int j = 1; j <= i; j++)
                {
                    dolars += "$ ";                    
                }
                
                Console.WriteLine(dolars.TrimEnd());
            }
        }
    }
}
