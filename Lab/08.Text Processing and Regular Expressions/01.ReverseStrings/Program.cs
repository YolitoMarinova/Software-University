using System;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                char[] lettersInReverseOrder = input.ToCharArray();
                Array.Reverse(lettersInReverseOrder);

                string reverseWord = new String(lettersInReverseOrder);

                Console.WriteLine($"{input} = {reverseWord}");
            }

        }
    }
}
