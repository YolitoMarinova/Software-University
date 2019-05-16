using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse);

            var sortedNumbers = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!sortedNumbers.ContainsKey(num))
                {
                    sortedNumbers[num] = 1;
                }
                else
                {
                    sortedNumbers[num]++;
                }
            }

            foreach (var item in sortedNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
