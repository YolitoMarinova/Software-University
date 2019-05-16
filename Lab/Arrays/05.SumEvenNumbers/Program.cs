using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main()
        {
            int[] numberInArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            foreach (var number in numberInArray)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
