using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long firstFactoriel = GetFactorial(firstNumber);
            long secondFactoriel = GetFactorial(secondNumber);

            double result = (double)firstFactoriel / secondFactoriel;

            Console.WriteLine($"{result:F2}");
        }
        private static long GetFactorial(int number)
        {
            if (number != 0)
            {
                long factorial = 1;
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
            return 0;
        }
    }
}
