using System;

public class Program
{
    public static void Main()
    {
        char startChar = char.Parse(Console.ReadLine());
        char endChar = char.Parse(Console.ReadLine());

        PrintCharsBetween(startChar, endChar);
    }
    public static void PrintCharsBetween(char startChar, char endChar)
    {
        if (startChar < endChar)
        {
            for (int i = startChar + 1; i < endChar; i++)
            {
                char letter = (char)i;
                Console.Write(letter + " ");
            }
        }
        else
        {
            for (int i = endChar + 1; i < startChar; i++)
            {
                char letter = (char)i;
                Console.Write(letter + " ");
            }
        }
    }
}