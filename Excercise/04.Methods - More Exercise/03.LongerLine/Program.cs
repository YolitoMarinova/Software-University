using System;
using System.Linq;

namespace _03.LongerLine
{
    class Program
    {
        static void Main()
        {
            double[] firstPair = new double[4];
            double[] secondPair = new double[4];

            firstPair = FillArrays(firstPair);
            secondPair = FillArrays(secondPair);

            PrintLongestLine(firstPair, secondPair);
        }

        private static double[] FillArrays(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            return array;
        }

        static void PrintLongestLine(double[] firstPair, double[] secondPair)
        {
            double x1 = Math.Abs(firstPair[0]);
            double y1 = Math.Abs(firstPair[1]);
            double x2 = Math.Abs(firstPair[2]);
            double y2 = Math.Abs(firstPair[3]);
            double x3 = Math.Abs(secondPair[0]);
            double y3 = Math.Abs(secondPair[1]);
            double x4 = Math.Abs(secondPair[2]);
            double y4 = Math.Abs(secondPair[3]);


            double firstSum = x1 + y1 + x2 + y2;
            double secondSum = x3 + y3 + x4 + y4;

            if (firstSum > secondSum)
            {
                PrintPair(firstPair, x1, y1, x2, y2);
            }
            else if (secondSum > firstSum)
            {
                PrintPair(secondPair, x3, y3, x4, y4);
            }
            else
            {
                PrintPair(firstPair, x1, y1, x2, y2);
            }
        }

        private static void PrintPair(double[] originalPair, double x1, double y1, double x2, double y2)
        {
            if ((x1 + y1) > (x2 + y2))
            {
                Console.WriteLine($"({originalPair[2]}, {originalPair[3]})({originalPair[0]}, {originalPair[1]})");
            }
            else if ((x2 + y2) > (x1 + y1))
            {
                Console.WriteLine($"({originalPair[0]}, {originalPair[1]})({originalPair[2]}, {originalPair[3]})");
            }
            else
            {
                Console.WriteLine($"({originalPair[0]}, {originalPair[1]})({originalPair[2]}, {originalPair[3]})");
            }
        }

        private static double[] TakeMathAbsOfArray(double[] firstPair)
        {
            for (int i = 0; i < firstPair.Length; i++)
            {
                firstPair[i] = Math.Abs(firstPair[i]);
            }
            return firstPair;
        }
    }
}