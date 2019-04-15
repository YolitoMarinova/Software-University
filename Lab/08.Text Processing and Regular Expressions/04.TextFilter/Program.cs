using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));

            }

            Console.WriteLine(text);
        }
    }
}
