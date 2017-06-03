using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zala
{
    class zala
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());//дължина
            double w = double.Parse(Console.ReadLine());//широчина

            int n_line = (int)(h / 1.20); // брой в линия 
            Console.WriteLine(n_line);

            int n_col = (int)((w - 1) / 0.7); // брой в колона
            Console.WriteLine(n_col);

            Console.WriteLine((n_line * n_col) - 3);
        }
    }
}
