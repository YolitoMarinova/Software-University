using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digit = i;
                int sum = 0;
                while (digit > 0)
                {
                   sum+= digit % 10;  
                   digit = digit / 10;
                }
                if (sum == 5 ||
                    sum == 7 ||
                    sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
