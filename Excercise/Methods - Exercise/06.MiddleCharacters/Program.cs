using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMiddleCharacter(input));
        }

        private static string GetMiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                int middle = input.Length / 2;
                string result = input[middle-1].ToString() + input[middle].ToString();
                return result;
            }
            else
            {
                int middle =(input.Length+1) / 2;
                string result = input[middle-1].ToString();
                return result;
            }
        }
    }
}
