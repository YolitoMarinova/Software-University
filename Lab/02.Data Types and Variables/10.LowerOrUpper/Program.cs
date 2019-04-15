using System;
using System.Globalization;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter == char.ToLower(letter))
            {
                Console.WriteLine("lower-case");
            }
            else if (letter==char.ToUpper(letter))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
