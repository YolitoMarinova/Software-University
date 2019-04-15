using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int num = i; 
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                bool isSpecialNum = false;
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecialNum}");
  
            }
        }
    }
}
