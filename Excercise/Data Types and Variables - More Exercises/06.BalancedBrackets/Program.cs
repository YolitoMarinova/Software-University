using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int openBracket = 0;
            int closingBracket = 0;

            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine();
                char bracket;

                if (char.TryParse(input, out bracket) == true)
                {
                    if (bracket == '(')
                    {
                        openBracket++;
                    }
                    else if (bracket == ')' && openBracket>closingBracket)
                    {
                        closingBracket++;
                    }
                }

            }

            if (openBracket == closingBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
