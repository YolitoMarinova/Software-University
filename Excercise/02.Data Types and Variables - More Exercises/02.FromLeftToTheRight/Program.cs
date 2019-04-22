using System;
using System.Linq;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < row; i++)
            {
                string input = Console.ReadLine();
                string[] s = input.Split(' ');
                long first=long.Parse(s[0]);
                long second=long.Parse(s[1]);
                long sumOfDigit = 0;

                if (first >= second)
                {
                    long digits = Math.Abs(first);
                    for (long j = 0; j < first.ToString().Length; j++)
                    {                      
                        long lastDigit = digits % 10;
                        sumOfDigit += lastDigit;
                        digits /= 10;
                    }
                }
                else
                {
                    long digits = Math.Abs(second);

                    for (long k = 0; k < second.ToString().Length; k++)
                    {
                        long lastDigit = digits % 10;
                        sumOfDigit += lastDigit;
                        digits /= 10;
                    }
                }
                Console.WriteLine(sumOfDigit);

            }
            
        }
    }
}
