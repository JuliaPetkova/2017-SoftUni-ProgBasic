using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int FanNumber = int.Parse(Console.ReadLine());

            double price; // цена на билита
            double sum; // оставащата сума след закупуване или липсващата сума

            if (FanNumber >= 50) // проверка за брой фенове
            {
                double tickets = budjet - ((budjet * 25) / 100); // колко остават за закупуване на билети

                if (category == "VIP") // проверка за какъва категория билети
                {
                    price = 499.99;
                    sum = tickets - (price * FanNumber);

                    if (sum >= 0) // проверка дали остават за по един билет на фен
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
                else
                {
                    price = 249.99;
                    sum = tickets - (price * FanNumber);
                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
            }
            else if (FanNumber < 50 && FanNumber >= 25)
            {
                double tickets = budjet - ((budjet * 40) / 100);

                if (category == "VIP")
                {
                    price = 499.99;
                    sum = tickets - (price * FanNumber);

                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
                else
                {
                    price = 249.99;
                    sum = tickets - (price * FanNumber);
                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }


            }
            else if (FanNumber < 25 && FanNumber >= 10)
            {
                double tickets = budjet - ((budjet * 50) / 100);

                if (category == "VIP")
                {
                    price = 499.99;
                    sum = tickets - (price * FanNumber);

                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
                else
                {
                    price = 249.99;
                    sum = tickets - (price * FanNumber);
                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }

            }
            else if (FanNumber < 10 && FanNumber >= 5)
            {
                double tickets = budjet - ((budjet * 60) / 100);

                if (category == "VIP")
                {
                    price = 499.99;
                    sum = tickets - (price * FanNumber);

                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
                else
                {
                    price = 249.99;
                    sum = tickets - (price * FanNumber);
                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
            }
            else if (FanNumber < 5 && FanNumber >= 1)
            {
                double tickets = budjet - ((budjet * 75) / 100);
                if (category == "VIP")
                {
                    price = 499.99;
                    sum = tickets - (price * FanNumber);

                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
                else
                {
                    price = 249.99;
                    sum = tickets - (price * FanNumber);
                    if (sum >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", sum);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(sum));
                    }
                }
            }
        }

    }
}

