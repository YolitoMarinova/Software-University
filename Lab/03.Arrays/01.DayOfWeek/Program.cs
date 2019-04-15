using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int numberOfDay = int.Parse(Console.ReadLine());

            string[] nameOfDay = { "Monday", "Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

            if (numberOfDay >=1 && numberOfDay<=7)
            {
                Console.WriteLine(nameOfDay[numberOfDay-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
