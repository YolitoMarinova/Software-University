using System;

namespace _03.pthBit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            n = n >> p;

            Console.WriteLine(n & 1);
        }
    }
}
