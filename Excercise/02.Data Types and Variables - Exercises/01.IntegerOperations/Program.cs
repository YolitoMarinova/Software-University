using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourNum = int.Parse(Console.ReadLine());

            int sum = (firstNum + secondNum)/thirdNum*fourNum;
            Console.WriteLine(sum);
        }
    }
}
