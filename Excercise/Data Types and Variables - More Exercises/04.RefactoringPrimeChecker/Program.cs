using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool itsPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        itsPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {itsPrime.ToString().ToLower()}");
            }
        }
    }
}
