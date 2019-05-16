using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            NumbersThatAreDivisbleByEight(number);
        }

        private static void NumbersThatAreDivisbleByEight(int number)
        {
            for (int i = 10; i <= number; i++)
            {
                int devisibleByEight = i;
                int sum = 0;
                while (devisibleByEight > 0)
                {
                    int lastDigit = devisibleByEight % 10;
                    sum += lastDigit;
                    devisibleByEight = devisibleByEight / 10;
                }

                int isHaveOddNumber = i;
                bool oddNumber = false;

                while (isHaveOddNumber > 0)
                {
                    int lastDigit = isHaveOddNumber % 10;
                    if (lastDigit % 2 != 0)
                    {
                        oddNumber = true;
                        break;
                    }
                    isHaveOddNumber = isHaveOddNumber / 10;
                }
                if (sum % 8 == 0 && oddNumber==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
