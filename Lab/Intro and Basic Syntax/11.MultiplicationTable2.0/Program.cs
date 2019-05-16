using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            if (startNumber <= 10)
            {
                for (int i = startNumber; i <= 10; i++)
                {
                    sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
            else
            {
                sum = number * startNumber;
                Console.WriteLine($"{number} X {startNumber} = {sum}");
            }
        }
    }
}
