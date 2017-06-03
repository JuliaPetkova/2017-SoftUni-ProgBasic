using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_p13_Area_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string FigType = Console.ReadLine();

           // string square;
           // string rectangle;
           // string circle;
           // string triangle;

            if (FigType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double s = Math.Round((Math.Pow(a, 2)), 3);
                Console.WriteLine(s);
            }

            else if (FigType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = Math.Round(a * b, 3);
                Console.WriteLine(s);
            }

            else if (FigType == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double s = Math.Round(Math.PI * (Math.Pow(a, 2)), 3); // p*r*r
                Console.WriteLine(s);
            }

            else if (FigType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double s = Math.Round((a * h) / 2, 3);// {0:F3} закръгля до 3-тия знак
                Console.WriteLine(s);
            }
        }
    }
}
