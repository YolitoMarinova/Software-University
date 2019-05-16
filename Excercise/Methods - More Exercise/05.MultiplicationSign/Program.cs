using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double[] numbers = new double[3];

            numbers = FilArrayWithNumber(numbers);


            PrintSignOfMultiplication(numbers);

        }

        private static double[] FilArrayWithNumber(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            return numbers;
        }

        private static void PrintSignOfMultiplication(double[] numbers)
        {
            int counterOfNegatives = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    counterOfNegatives++;
                }
                else if (numbers[i] == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
            }

            if (counterOfNegatives == 2 || counterOfNegatives == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
