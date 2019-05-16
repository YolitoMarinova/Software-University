using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double areaOfTriangle = GetAreaOfTriangle(width, hight);

            Console.WriteLine(areaOfTriangle);
        }

        private static double GetAreaOfTriangle(double width, double hight)
        {
            return width * hight;
        }
    }
}
