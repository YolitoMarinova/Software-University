using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int integer = 0;
            float floatNumber = 0;
            char character;
            bool yesOrNo ;


            while (input != "END")
            {
                if (int.TryParse(input, out integer) == true)
                {
                    Console.WriteLine($"{input} is integer type");
                    input = Console.ReadLine();
                }
                else if (char.TryParse(input, out character) == true)
                {
                    Console.WriteLine($"{input} is character type");
                    input = Console.ReadLine();

                }
                else if (float.TryParse(input, out floatNumber) == true)
                {
                    Console.WriteLine($"{input} is floating point type");
                    input = Console.ReadLine();

                }
                else if (bool.TryParse(input, out yesOrNo) == true)
                {
                    Console.WriteLine($"{input} is boolean type");
                    input = Console.ReadLine();

                }
                else 
                {
                    Console.WriteLine($"{input} is string type");
                    input = Console.ReadLine();

                }
            }
        }
    }
}
