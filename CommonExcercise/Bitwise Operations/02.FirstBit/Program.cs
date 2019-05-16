using System;

namespace _02.FirstBit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            n = n >> 1;

            Console.WriteLine(n & 1);
        }
    }
}
