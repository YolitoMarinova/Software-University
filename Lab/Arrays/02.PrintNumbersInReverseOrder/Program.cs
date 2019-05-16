using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] arrays = new int[numbers];

            for (int i = 0; i < arrays.Length; i++)
           {
                arrays[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Reverse(arrays);
            foreach (int number in arrays)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
