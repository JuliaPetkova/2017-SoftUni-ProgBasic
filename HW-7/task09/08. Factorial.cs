using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    class task09
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factoriel = 1;
            int count = 1;

            while (count <=n )
            {
                factoriel = factoriel * count;
                count++;
            }
            Console.WriteLine(factoriel);
        }
    }
}
