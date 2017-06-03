using System;

namespace _4_task_Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input firts name:  ");
            var a = Console.ReadLine();

            //Console.Write("Input last name:  ");
            var b = Console.ReadLine();

            //  Console.Write("Input your age:  ");
            var c = int.Parse(Console.ReadLine());

            // Console.Write("Input your town:  ");
            var d = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", a, b, c, d);

        }
    }
}
