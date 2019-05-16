using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());


            int sum = 0;
            int nums = number;
            int factoriel = 0;



            for (int i = 1; i <= number.ToString().Length; i++)

            {

                int lastDigit = nums % 10;
                if (lastDigit == 1)
                {
                    factoriel = 1;
                }
                else
                {
                    factoriel = lastDigit * (lastDigit - 1);
                    for (int j = lastDigit - 1; j > 2; j--) //3
                    {
                        factoriel = factoriel * (j - 1);

                    }
                }
                sum += factoriel;
                nums = nums / 10;
            }



            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
