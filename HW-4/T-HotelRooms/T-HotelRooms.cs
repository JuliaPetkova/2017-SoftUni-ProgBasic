using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_HotelRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (months == "May" || months == "October")
            {
                if (nights >= 7 && nights <= 14)
                {
                    double sumAppart = (nights * 65.00);
                    double sumStusio = (nights * 50.00) - (nights * 50.00) * 5 / 100;

                    Console.WriteLine("Apartment: {0:f2} lv.", sumAppart);
                    Console.WriteLine("Studio: {0:f2} lv.", sumStusio);
                }
                else
                {
                    double sumAppart = (nights * 65.00) - (nights * 65.00) * 10 / 100;
                    double sumStusio = (nights * 50.00) - (nights * 50.00) * 30 / 100;

                    Console.WriteLine("Apartment: {0:f2} lv.", sumAppart);
                    Console.WriteLine("Studio: {0:f2} lv.", sumStusio);
                }
            }

            else if (months == "June" || months == "September ")
            {

                if (nights <= 14)
                {
                    double sumAppart = (nights * 68.70);
                    double sumStusio = (nights * 75.20);

                    Console.WriteLine("Apartment: {0:f2} lv.", sumAppart);
                    Console.WriteLine("Studio: {0:f2} lv.", sumStusio);
                }
                else 
                {
                    double sumAppart = (nights * 68.70) - (nights * 68.70) * 10 / 100;
                    double sumStusio = (nights * 75.20) - (nights * 75.20) * 20 / 100;

                    Console.WriteLine("Apartment: {0:f2} lv.", sumAppart);
                    Console.WriteLine("Studio: {0:f2} lv.", sumStusio);
                }
            }
            else if (months == "July" || months == "August")
            {

                if (nights <= 14)
                {
                    double sumAppart = (nights * 77.00);
                    double sumStusio = (nights * 76.00);

                    Console.WriteLine("Apartment: {0:f2} lv.", sumAppart);
                    Console.WriteLine("Studio: {0:f2} lv.", sumStusio);
                }
                else
                {
                    double sumAppart = (nights * 77.00) - (nights * 77.00) * 10 / 100;
                    double sumStusio = (nights * 76.00);

                    Console.WriteLine("Apartment: {0:f2} lv.", sumAppart);
                    Console.WriteLine("Studio: {0:f2} lv.", sumStusio);
                }
            }
        }
    }
}
