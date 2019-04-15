using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (firstArray.SequenceEqual(secondArray))
            {
                int sum = firstArray.Sum();
                Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine($"Arrays are not identical. " +
                            $"Found difference at {i} index");
                        break;
                    }
                }
            }
        }
    }
}
