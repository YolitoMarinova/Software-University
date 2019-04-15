using System;
using System.Text.RegularExpressions;

namespace _07.MatchDates
{
    class Program
    {
        static void Main()
        {
            string inputDates = Console.ReadLine();

            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection validDates = Regex.Matches(inputDates,regex);

            foreach (Match date in validDates)
            {
                
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
