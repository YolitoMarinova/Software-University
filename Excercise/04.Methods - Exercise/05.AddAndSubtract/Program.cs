using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumOfFirstAndSecond = SumOfFirstAndSecondDigit(firstNumber,secondNumber);
            int subtract = SubtractThirdFromSum(thirdNumber,sumOfFirstAndSecond);

            Console.WriteLine(subtract);


        }

        private static int SubtractThirdFromSum(int thirdNumber, int sumOfFirstAndSecond)
        {
            int subtract = sumOfFirstAndSecond - thirdNumber;
            return subtract;
        }

        private static int SumOfFirstAndSecondDigit(int firstNumber, int secondNumber)
        {
            int sumOfDigits = firstNumber + secondNumber;
            return sumOfDigits;
        }
    }
}
