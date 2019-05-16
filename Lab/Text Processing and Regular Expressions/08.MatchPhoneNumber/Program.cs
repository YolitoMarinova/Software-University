using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08.MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string inputPhoneNumbers = Console.ReadLine();
            string regex = @"(?!<\d)[+]359([ -])2\1(\d{3})\1(\d{4})\b";

            MatchCollection validPhoneNumbers = Regex.Matches(inputPhoneNumbers,regex);

            List<string> phoneNumbers = new List<string>();

            foreach (Match phNum in validPhoneNumbers)
            {
                phoneNumbers.Add(phNum.Value);
            }

            Console.WriteLine(String.Join(", ",phoneNumbers));
        }
    }
}
