using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main()
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(CalculateResult(number));
            }
            else if (dataType == "real")
            {
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateResult(doubleNumber):F2}");
            }
            else if (dataType == "string")
            {
                string text = Console.ReadLine();
                Console.WriteLine(CalculateResult(text));
            }
        }

        static int CalculateResult(int number)
        {
            return number * 2;
        }

        static double CalculateResult(double doubleNumber)
        {
            return doubleNumber * 1.50;
        }

        static string CalculateResult(string text)
        {
            return $"${text}$";
        }


    }
}
