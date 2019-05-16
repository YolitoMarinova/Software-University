using System;

namespace _07.NxN_atrix
{
    class Program
    {
        static void Main()
        {
            int numberOfMatrix = int.Parse(Console.ReadLine());

            PrintMatrix(numberOfMatrix);
        }

        private static void PrintMatrix(int numberOfMatrix)
        {
            for (int i = 0; i < numberOfMatrix; i++)
            {
                for (int j = 0; j < numberOfMatrix; j++)
                {
                    Console.Write(numberOfMatrix + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
