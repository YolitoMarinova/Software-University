using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            bool itsEquel = false;
            int equalIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;


                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                if (leftSum == rightSum)
                {
                    itsEquel = true;
                    equalIndex = i;
                }

            }

            if (itsEquel == true)
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
