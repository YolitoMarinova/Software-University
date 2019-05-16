using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetMinValue(firstNumber, secondNumber, thirdNumber));
            
        }

        private static int GetMinValue(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                return secondNumber;
            }
            else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                return thirdNumber;
            }
            return 0;
        }
    }
}
