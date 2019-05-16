using System;

public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();

        Console.WriteLine(GetCountOfVowels(text));

    }
    public static int GetCountOfVowels(string text)
    {
        int countOfVowels = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];

            if (letter == 'a' || letter == 'A' ||
               letter == 'e' || letter == 'E' ||
               letter == 'i' || letter == 'I' ||
               letter == 'o' || letter == 'O' ||
               letter == 'u' || letter == 'U')
            {
                countOfVowels++;
            }
        }

        return countOfVowels;
    }
}