using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
