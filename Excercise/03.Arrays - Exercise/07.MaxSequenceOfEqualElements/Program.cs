using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxSequence = -1;
            int indexOfMaxSeuence = 0;


            int count = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                   
                    count++;

                    if (count > maxSequence)

                    {
                        maxSequence = count;
                        indexOfMaxSeuence = i;

                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 1; i <= maxSequence; i++)
            {
                Console.Write(array[indexOfMaxSeuence] + " ");
            }
        }
    }
}