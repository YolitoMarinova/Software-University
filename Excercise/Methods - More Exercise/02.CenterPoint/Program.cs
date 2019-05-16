using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CloseToZero(x1, y1, x2, y2);
        }

        static void CloseToZero(double firstX, double firstY, double secondX, double secondY)
        {
            double x1 = Math.Abs(firstX);
            double y1 = Math.Abs(firstY);
            double x2 = Math.Abs(secondX);
            double y2 = Math.Abs(secondY);

            if ((x1 + y1) < (x2 + y2))
            {
                Console.WriteLine($"({firstX}, {firstY})");
            }
            else if ((x2 + y2) < (x1 + y1))
            {
                Console.WriteLine($"({secondX}, {secondY})");

            }
            else
            {
                Console.WriteLine($"({firstX}, {firstY})");

            }
        }
    }
}
