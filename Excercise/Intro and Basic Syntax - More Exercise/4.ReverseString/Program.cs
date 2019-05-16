using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string backWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                backWord += word[i];
            }

            Console.WriteLine(backWord);
        }
    }
}
