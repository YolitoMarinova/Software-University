using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[] fromLeft = new int[rows];
            int[] fromRight = new int[rows]; 

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    fromLeft[i] = numbers[0];
                    fromRight[i] = numbers[1];

                }
                else
                {
                    fromLeft[i] = numbers[1];
                    fromRight[i] = numbers[0];
                }
            }

            Console.WriteLine(String.Join(" ",fromLeft));
            Console.WriteLine(String.Join(" ",fromRight));
        }
    }
}
