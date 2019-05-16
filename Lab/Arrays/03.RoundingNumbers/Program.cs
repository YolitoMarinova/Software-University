using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main()
        {
            string doubleNumbers = Console.ReadLine();
            double[] array = doubleNumbers.Split().Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
            }
           
        }
    }
}
