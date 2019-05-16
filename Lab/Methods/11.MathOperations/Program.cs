using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = CalcResult(firstNumber,@operator,secondNumber);
            Console.WriteLine(result);

        }

        private static double CalcResult(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0.00;

            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
