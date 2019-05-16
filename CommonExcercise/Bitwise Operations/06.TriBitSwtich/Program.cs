using System;

namespace _06.TriBitSwtich
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7;

            mask = mask << position;

            Console.WriteLine(number^mask);
        }
    }
}
