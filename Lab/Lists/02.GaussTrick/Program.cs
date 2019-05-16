using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            if (numbers.Count % 2 == 0)
            {
                int count = numbers.Count / 2;
                for (int i = 0; i < count; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            else
            {
                int count = numbers.Count / 2;
                int middleIndex = count + 1;
                for (int i = 0; i < count; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
                
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
