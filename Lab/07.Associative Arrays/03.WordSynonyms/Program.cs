using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main()
        {
            var words = new Dictionary<string,List<string>>();

            int numberOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    words[word].Add(synonym);
                }
                else
                {
                    words[word]=new List<string> { synonym};
                }
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ",word.Value)}");
            }
        }
    }
}
