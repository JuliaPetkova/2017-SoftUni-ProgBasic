using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zala_1
{
    class Program
    {
        static void Main(string[] args)
        {
// задачата не е вярна по този начин, 
// защото бюрата са подредени в редове и колони, а не набутани в залата
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            double s = (h * (w - 1));
            double s1 = 0.7 * 1.2;

            double n = (s / s1)-(3*s1);
            Console.WriteLine(n);

        }
    }
}
