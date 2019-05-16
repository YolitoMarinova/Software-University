using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main()
        {
            double britishPound = double.Parse(Console.ReadLine());
            double dollars = britishPound * 1.31;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
