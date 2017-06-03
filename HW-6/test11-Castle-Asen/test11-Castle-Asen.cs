using System;

class DrawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int colSize = n / 2;
        int midSize = 2 * n - 2 * colSize - 4;

        // first row
        Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', colSize),
            new string('_', midSize));

        // Middle rows
        for (var row = 1; row <= n - 3; row++)
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));

        // before the last
        Console.WriteLine("|{0}{1}{0}|",
            new string(' ', colSize + 1),
            new string('_', midSize));

        // last row
        Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', colSize),
            new string(' ', midSize));
    }
}