using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindromeIntegers(input));

                input = Console.ReadLine();
            }
        }

        private static string IsPalindromeIntegers(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reverse=new String(array);
            if ( reverse== input)
            {
                return "true";
            }
            return "false";
        }
    }
}
