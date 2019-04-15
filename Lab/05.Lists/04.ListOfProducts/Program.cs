using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
