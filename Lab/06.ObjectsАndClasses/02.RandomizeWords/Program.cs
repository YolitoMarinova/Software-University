using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split(" ").ToList();

            Random randomWords = new Random();

            for (int pos1 = 0; pos1 < words.Count; pos1++)
            {
                int pos2 = randomWords.Next(words.Count);

                string toAdd = words[pos2];
                words.Remove(words[pos2]);
                words.Insert(pos1,toAdd);                
            }

            Console.WriteLine(String.Join(Environment.NewLine,words));
        }
        
    }
}
