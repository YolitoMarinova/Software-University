using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];

                    if (sum == number)
                    {
                        int[] magicNumbers = new int[] { array[i], array[j] };
                        Console.WriteLine(String.Join(" ", magicNumbers));
                    }

                }
            }
        }

    }
}

