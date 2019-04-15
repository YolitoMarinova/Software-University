using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int multipleOfEvenAndOdds = GetMultipleOfEvenAndOdds(Math.Abs(number));
            Console.WriteLine(multipleOfEvenAndOdds);
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumOfEvenNumbers = SumOfEvenNumbers(number);
            int sumOfOddNumbers = SumOfOddNumbers(number);

            int multiple = sumOfEvenNumbers * sumOfOddNumbers;
            return multiple;
        }

        private static int SumOfEvenNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastNum = number % 10;
                if (lastNum % 2 != 0)
                {
                    sum += lastNum;
                }
               
                number=number / 10;
            }
            return sum;
        }

        private static int SumOfOddNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastNum = number % 10;
                if (lastNum % 2 == 0)
                {
                    sum += lastNum;
                }

                number = number / 10;
            }
            return sum;
        }

        
    }
}
