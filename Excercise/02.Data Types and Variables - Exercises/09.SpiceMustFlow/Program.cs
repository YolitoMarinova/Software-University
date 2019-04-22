using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int sumOfYield = 0;

            while (startingYield >= 100)
            {
                sumOfYield += startingYield - 26;
                startingYield -= 10;
                days++;
            }

            if (sumOfYield >= 26)
            {
                sumOfYield -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(sumOfYield);
        }
    }
}
