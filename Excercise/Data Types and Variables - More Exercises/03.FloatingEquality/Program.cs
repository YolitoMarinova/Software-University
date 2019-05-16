using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main()
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            decimal fixConst = 0.000001M;

            decimal diffrent = Math.Abs(firstNum)-Math.Abs(secondNum);

            if (diffrent >= fixConst)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
