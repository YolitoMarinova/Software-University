using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> original = FillOriginalList(numbers);

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(IsCointain(numbers, command[1]));
                        break;
                    case "PrintEven":
                        Console.WriteLine(String.Join(" ", GetEvenNumbers(numbers)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(String.Join(" ", GetOddNumbers(numbers)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        PrintFilterList(numbers, command[1], int.Parse(command[2]));
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }

            var firstNotSecond = original.Except(numbers).ToList();
            var secondNotFirst = numbers.Except(original).ToList();
            var first = !firstNotSecond.Any();
            var second = !secondNotFirst.Any();
            if (!first || !second)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        private static List<int> GetOddNumbers(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            return oddNumbers;
        }

        private static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            return evenNumbers;
        }

        private static string IsCointain(List<int> numbers, string num)
        {
            if (numbers.Contains(int.Parse(num)))
                return "Yes";
            else
                return "No such number";
        }

        private static List<int> FillOriginalList(List<int> numbers)
        {
            List<int> original = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                original.Add(numbers[i]);
            }
            return original;
        }

        private static void PrintFilterList(List<int> numbers, string sign, int number)
        {
            switch (sign)
            {

                case "<":
                    List<int> numbers1 = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < number)
                        {
                            numbers1.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", numbers1));
                    break;
                case ">":
                    List<int> numbers2 = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > number)
                        {
                            numbers2.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", numbers2));
                    break;
                case ">=":
                    List<int> numbers3 = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= number)
                        {
                            numbers3.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", numbers3));
                    break;
                case "<=":
                    List<int> numbers4 = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= number)
                        {
                            numbers4.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", numbers4));
                    break;
            }
        }
    }
}
