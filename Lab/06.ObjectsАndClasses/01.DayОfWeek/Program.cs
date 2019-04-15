using System;
using System.Globalization;

namespace _01.DayОfWeek
{
    class Program
    {
        static void Main()
        {
            string date = Console.ReadLine();

            DateTime takeDate =DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(takeDate.DayOfWeek);
        }
    }
}
