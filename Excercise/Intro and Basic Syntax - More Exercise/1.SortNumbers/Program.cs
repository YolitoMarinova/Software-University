using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[3];

            for (int i = 0; i <= 2; i++)
            { 
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Array.Sort(array);
            Array.Reverse(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);

            }

        }
    }
}
