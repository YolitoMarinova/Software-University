using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(x => x <= 0);

            if (numbers.Count > 0)
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    Console.Write(numbers[i]+" ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
