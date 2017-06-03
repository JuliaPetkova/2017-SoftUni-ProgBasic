using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_13_PointInOutFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool insideR1 = x > 0 && x < (3 * h) && y > 0 && y < h;
            bool insideR2 = x > h && x < (2 * h) && y > h && y < (4 * h);
            bool insideCommon = x > h && x < (2 * h) && y == h; // общата стеничка

            bool border1 = x == 0 && y <= h;
            bool border2 = y == 0 && x <= (3 * h) && x>=0;
            bool border3 = x == (3 * h) && y <= h && y>=0;
            bool border4 = (y == h) && (x >= (2 * h)) && (x <= (3 * h));
            bool border5 = (y == h) && (x >= 0) && (x <= h);
            bool border6 = (y >= h) && (y <= (4 * h)) && (x == h);
            bool border7 = (y >= h) && (y <= (4 * h)) && (x == (2 * h));
            bool border8 = (y == (4 * h)) && (x >= h) && (x <= (2 * h));


            if (insideR1 || insideR2 || insideCommon)
            {
                Console.WriteLine("inside");
            }
            else if (border1 || border2 || border3 || border4 || border5 || border6 || border7 || border8)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
