using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            string result = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString();
            Console.WriteLine(result);
        }
    }
}
