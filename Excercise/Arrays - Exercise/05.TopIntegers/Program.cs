﻿using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool isBigger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
