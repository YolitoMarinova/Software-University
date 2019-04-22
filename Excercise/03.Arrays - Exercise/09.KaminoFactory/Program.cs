using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int lengthOfDNA = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int[] bestDNA = new int[lengthOfDNA];
            int maxSequence = -1;
            int sample = 0;
            int bestStart =0 ;
            int bestSum = 0;
            int counterOfArrays = 0;

            while (input != "Clone them!")
            {
                int[] numbers = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                counterOfArrays++;
                int sum = 0;
                int counter = 0;
                int sequences = -1;
                int startIndex = -1;

                for (int i = 0; i < lengthOfDNA; i++)
                {
                    if (numbers[i] == 1)
                    {
                        counter++;
                        sum++;
                        if (counter > sequences)
                        {
                            sequences = counter;
                            startIndex = i - counter;
                        }
                    }
                    else { counter = 0; }
                }

                if (sequences > maxSequence)
                {
                    maxSequence = sequences;
                    bestStart = startIndex;
                    bestDNA = numbers;
                    bestSum = sum;
                    sample = counterOfArrays;
                }
                if (sequences == maxSequence && startIndex < bestStart)
                {
                    maxSequence = counter;
                    sample = counterOfArrays;
                    bestStart = startIndex;
                    bestDNA = numbers;
                    bestSum = sum;
                }
                else if (sequences == maxSequence && startIndex == bestStart && sum > bestSum)
                {
                    maxSequence = counter;
                    sample = counterOfArrays;
                    bestStart = startIndex;
                    bestDNA = numbers;
                    bestSum = sum;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {sample} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestDNA));
        }
    }
}
