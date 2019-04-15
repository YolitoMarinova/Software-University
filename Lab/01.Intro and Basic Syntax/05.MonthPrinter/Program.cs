using System;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main()
        {
            int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber >= 1 && monthNumber <= 12)
            {
                if (monthNumber == 1)
                {
                    Console.WriteLine("January");
                }
                if (monthNumber == 2)
                {
                    Console.WriteLine("February");
                }
                if (monthNumber == 3)
                {
                    Console.WriteLine("March");
                }
                if (monthNumber == 4)
                {
                    Console.WriteLine("April");
                }
                if (monthNumber == 5)
                {
                    Console.WriteLine("May");
                }
                if (monthNumber == 6)
                {
                    Console.WriteLine("June");
                }
                if (monthNumber == 7)
                {
                    Console.WriteLine("July");
                }
                if (monthNumber == 8)
                {
                    Console.WriteLine("August");
                }
                if (monthNumber == 9)
                {
                    Console.WriteLine("September");
                }
                if (monthNumber == 10)
                {
                    Console.WriteLine("Octomber");
                }
                if (monthNumber == 11)
                {
                    Console.WriteLine("November");
                }
                if (monthNumber == 12)
                {
                    Console.WriteLine("December");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
