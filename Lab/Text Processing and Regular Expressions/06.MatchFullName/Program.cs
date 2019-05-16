using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.MatchFullName
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matches = Regex.Matches(input,regex);

            List<string> names = new List<string>();

            foreach (Match name in matches)
            {
                names.Add(name.Value);
            }

            Console.WriteLine(String.Join(" ",names));
        }
    }
}
