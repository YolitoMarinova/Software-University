using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int numberOfCopy = int.Parse(Console.ReadLine());
            PrintResult(input, numberOfCopy);
            Console.WriteLine();


        }

        private static string PrintResult(string input, int numberOfCopy)
        {
            string result = "";

            for (int i = 0; i < numberOfCopy; i++)
            {
                Console.Write(input);
            }

            return result;
        }
    }
}
