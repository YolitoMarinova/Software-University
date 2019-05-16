using System;

namespace _03.Substring
{
    class Program
    {
        static void Main()
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string textToChange = Console.ReadLine();

            while (textToChange.Contains(wordToRemove))
            {
                int index = textToChange.IndexOf(wordToRemove);
                textToChange = textToChange.Remove(index, wordToRemove.Length);
            }

            Console.WriteLine(textToChange);
        }
    }
}
