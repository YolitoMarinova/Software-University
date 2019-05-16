using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string typeOfValue = Console.ReadLine();
            ReturnMaxValue(typeOfValue);
        }

        private static void ReturnMaxValue(string typeOfValue)
        {
            if (typeOfValue == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                GetMaxValue(firstNumber, secondNumber);

            }
            else if (typeOfValue == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                GetMaxValueOfChar(firstChar, secondChar);

            }
            else if (typeOfValue == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                GetMaxValueFromString(firstString, secondString);
            }
        }
        private static void GetMaxValue(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine(secondValue);
            }
        }
        private static void GetMaxValueOfChar(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                Console.WriteLine($"{firstChar}");
            }
            else
            {
                Console.WriteLine($"{secondChar}");
            }
        }

        private static void GetMaxValueFromString(string firstString, string secondString)
        {
            switch (String.Compare(firstString, secondString))
            {
                case 1:
                    Console.WriteLine(firstString);
                    break;
                case -1:
                    Console.WriteLine(secondString);
                    break;
            }
        }

        
    }
}
