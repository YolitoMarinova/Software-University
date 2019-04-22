using System;
using System.Linq;
using System.Text;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command.Contains("exchange"))
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < numbers.Length)
                    {
                        numbers = ExchangeArrayOfNumbers(numbers, command[1]);
                    }
                    else Console.WriteLine("Invalid index");
                }
                else if (command[0] == "max" && command[1] == "even")
                {
                    PrintMaxEvenIndex(numbers);
                }
                else if (command[0] == "max" && command[1] == "odd")
                {
                    PrintMaxOddIndex(numbers);
                }
                else if (command[0] == "min" && command[1] == "even")
                {
                    PrintMinEvenIndex(numbers);
                }
                else if (command[0] == "min" && command[1] == "odd")
                {
                    PrintMinOddIndex(numbers);
                }
                else if (command[0] == "first" && command[2] == "even")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= numbers.Length)
                    {
                        PrintFirstEvenElements(numbers, command[1]);
                    }
                    else Console.WriteLine("Invalid count");
                }
                else if (command[0] == "first" && command[2] == "odd")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= numbers.Length)
                    {
                       PrintFirstOddElements(numbers, command[1]);
                    }
                    else Console.WriteLine("Invalid count");
                }
                else if (command[0] == "last" && command[2] == "even")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= numbers.Length)
                    {
                       PrintLastEvenElements(numbers, command[1]);
                    }
                    else Console.WriteLine("Invalid count");
                }
                else if (command[0] == "last" && command[2] == "odd")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= numbers.Length)
                    {
                        PrintLastOddElements(numbers, command[1]);
                    }
                    else Console.WriteLine("Invalid count");
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine("[" + String.Join(", ", numbers) + "]");
        }

        private static void PrintLastOddElements(int[] numbers, string count)
        {
            string[] firstElements = new string[int.Parse(count)];
            int indexOfArray = firstElements.Length - 1;
            int countOfEven = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    countOfEven++;
                    if (countOfEven <= int.Parse(count))
                    {
                        firstElements[indexOfArray] = numbers[i].ToString();
                        indexOfArray--;
                    }
                }
            }

            firstElements = firstElements.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (countOfEven > 0)
            {
                Console.WriteLine("[" + String.Join(", ", firstElements) + "]");
            }
            else Console.WriteLine("[]");
        }

        private static void PrintLastEvenElements(int[] numbers, string count)
        {
            string[] firstElements = new string[int.Parse(count)];
            int indexOfArray = firstElements.Length-1;
            int countOfEven = 0;

            for (int i = numbers.Length-1; i >=0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    countOfEven++;
                    if (countOfEven <= int.Parse(count))
                    {
                        firstElements[indexOfArray] = numbers[i].ToString();
                        indexOfArray--;
                    }
                }
            }

            firstElements = firstElements.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (countOfEven > 0)
            {
                Console.WriteLine("[" + String.Join(", ", firstElements) + "]");
            }
            else Console.WriteLine("[]");
        }

        private static void PrintFirstOddElements(int[] numbers, string count)
        {
            string[] firstElements = new string[int.Parse(count)];
            int indexOfArray = 0;
            int countOfEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    countOfEven++;
                    if (countOfEven <= int.Parse(count))
                    {
                        firstElements[indexOfArray] = numbers[i].ToString();
                        indexOfArray++;
                    }
                }
            }

            firstElements = firstElements.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (countOfEven > 0)
            {
                Console.WriteLine("[" + String.Join(", ", firstElements) + "]");
            }
            else Console.WriteLine("[]");
        }

        private static void PrintFirstEvenElements(int[] numbers, string count)
        {
            string[] firstElements = new string[int.Parse(count)];
            int indexOfArray = 0;
            int countOfEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    countOfEven++;
                    if (countOfEven <= int.Parse(count))
                    {
                        firstElements[indexOfArray] = numbers[i].ToString();
                        indexOfArray++;
                    }
                }
            }

            firstElements = firstElements.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            if (countOfEven > 0)
            {
                Console.WriteLine("["+String.Join(", ", firstElements)+"]");
            }
            else Console.WriteLine("[]");
        }

        private static void PrintMinOddIndex(int[] numbers)
        {
            int minNumber = int.MaxValue;
            int minIndex = 0;
            int countOfEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] <= minNumber)
                    {
                        minNumber = numbers[i];
                        minIndex = i;
                    }
                    countOfEven++;
                }
            }
            if (countOfEven > 0)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMinEvenIndex(int[] numbers)
        {
            int minNumber = int.MaxValue;
            int minIndex = 0;
            int countOfEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] <= minNumber)
                    {
                        minNumber = numbers[i];
                        minIndex = i;
                    }
                    countOfEven++;
                }
            }
            if (countOfEven > 0)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMaxOddIndex(int[] numbers)
        {
            int maxNumber = -1;
            int maxIndex = 0;
            int countOfEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (numbers[i] >= maxNumber)
                    {
                        maxNumber = numbers[i];
                        maxIndex = i;
                    }
                    countOfEven++;
                }
            }
            if (countOfEven > 0)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMaxEvenIndex(int[] numbers)
        {
            int maxNumber = -1;
            int maxIndex = 0;
            int countOfEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] >= maxNumber)
                    {
                        maxNumber = numbers[i];
                        maxIndex = i;
                    }
                    countOfEven++;
                }
            }
            if (countOfEven > 0)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static int[] ExchangeArrayOfNumbers(int[] numbers, string indexs)
        {
            int index = int.Parse(indexs);

            int[] firstArray = numbers.Skip(index + 1).ToArray();
            int[] seconArray = numbers.Take(index + 1).ToArray();
            numbers = firstArray.Concat(seconArray).ToArray();

            return numbers;
        }
    }
}
