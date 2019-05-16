using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main()
        {
            int evenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {

                if (evenNumber % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");
                    break;

                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    evenNumber = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
