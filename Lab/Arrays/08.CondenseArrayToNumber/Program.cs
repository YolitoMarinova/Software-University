using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Middle_Elements
{
    class MiddleElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = numbers.Length;


            do
            {
                for (int i = 0; i < len-1; i++)
                {
                    numbers[i] +=numbers[i + 1];
                }
                len--;
            } while (len > 1);

            Console.WriteLine(numbers[0]);

        }
    }
}