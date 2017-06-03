using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4_SmartLili1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nYears = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double EvenSum = 0;
            double OddSum = 0;
            double sum = 0;     // всяка година се увеличава тази сума с 10
            double Sum = 0;   // EvenSum + OddSum

            int evenYears = 0;
            
            for (int i = 1; i <= nYears; i++)
            {
                if (i % 2 == 0)
                {
                    evenYears = evenYears + 1;
                    sum = (sum + 10);
                    EvenSum = (EvenSum + sum);
                }
                else
                {
                    OddSum = OddSum + toyPrice;
                }

            }
            //Console.WriteLine(evenYears);
            Sum = (EvenSum - evenYears * 1) + OddSum;
           // Console.WriteLine("even sum: {0} odd sum {1}", EvenSum, OddSum);

            if (Sum >= machinePrice)
            {
                Console.WriteLine("Yes! {0:F2}", (Sum - machinePrice));
            }
            else
            {
                Console.WriteLine("No! {0:F2}", (machinePrice - Sum));
            }

        }
    }
}
