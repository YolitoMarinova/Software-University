using System;
using System.Linq;

namespace _05.OddTimes
{
    class Program
    {
        static void Main()
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int results = arrayOfNumbers[0];

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                results = results ^ arrayOfNumbers[i];
            }
            Console.WriteLine(results);

        }
    }
}
