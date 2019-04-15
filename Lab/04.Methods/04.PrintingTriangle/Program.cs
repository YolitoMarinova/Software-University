using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main()
        
        {
            int triangleSize = int.Parse(Console.ReadLine());
            PrintingTriangle(triangleSize);
            PrintReverseTriangle(triangleSize-1);
        }

        private static void PrintingTriangle(int triangleSize)
        {
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
        private static void PrintReverseTriangle(int triangleSize)
        {
            for (int i = triangleSize; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            
        }

       
    }
}
