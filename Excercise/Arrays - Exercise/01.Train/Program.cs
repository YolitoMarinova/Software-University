using System;

namespace _01.Train
{
    class Program
    {
        static void Main()
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int sumOfPeople = 0;
            int[] peopleInWagon = new int[countOfWagons];

            for (int i = 0; i < countOfWagons; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sumOfPeople += peopleInWagon[i];
            }

            Console.WriteLine(String.Join(" ",peopleInWagon));
            Console.WriteLine(sumOfPeople);
        }
    }
}
