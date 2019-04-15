using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main()
        {
            string countryName = Console.ReadLine();
            string language;

            if (countryName == "England" || countryName == "USA")
            {
                language = "English";
                Console.WriteLine(language);
            }
            else if (countryName == "Spain" || countryName == "Argentina" || countryName == "Mexico")
            {
                language = "Spanish";
                Console.WriteLine(language);
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
