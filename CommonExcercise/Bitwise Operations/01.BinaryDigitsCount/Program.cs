using System;

namespace _01.BinaryDigitsCount
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int binaryNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            while (number > 0)
            {
                int digit = number % 2;

                if (digit == binaryNumber)
                {
                    counter++;
                }

                number /= 2;
            }

            Console.WriteLine(counter);
        }
    }
}
