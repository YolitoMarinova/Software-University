using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split();

            var counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            var validWord = counts.Where(x => x.Value % 2 != 0);

            foreach (var item in validWord)
            {
                Console.Write(item.Key+ " ");
            }
            Console.WriteLine();
        }
    }
}
