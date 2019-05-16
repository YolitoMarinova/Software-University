using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int powOfTheNumber = int.Parse(Console.ReadLine());

            double result=ReturnResult(number,powOfTheNumber);
            Console.WriteLine(result);
            
           
        }

        private static double ReturnResult(double number, int powOfTheNumber)
        {
            double result = number;

            for (int i = 1; i < powOfTheNumber; i++)
            {
                result = result * number;
            }
            return result;

        }
    }
}
