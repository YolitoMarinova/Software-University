using System;

public class Program
{
    public static void Main()
    {
        string password = Console.ReadLine();

        bool isCorrect = IsCorrectNumbersOfChars(password);
        if (isCorrect == false)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        bool correctCharacters = IsCharsLettersAndDigits(password);
        if (correctCharacters == false)
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        bool countOfDigits = CountOfDigits(password);
        if (countOfDigits == false)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }

        if (isCorrect == true && correctCharacters == true && countOfDigits == true)
        {
            Console.WriteLine("Password is valid");
        }
    }

    public static bool CountOfDigits(string password)
    {
        bool isCorrect = true;

        int countOfNumbers = 0;

        for (int i = 0; i < password.Length; i++)
        {
            if (Char.IsDigit(password[i]) == true)
            {
                countOfNumbers++;
            }
        }
        if (countOfNumbers < 2)
        {
            isCorrect = false;
        }

        return isCorrect;
    }

    public static bool IsCharsLettersAndDigits(string password)
    {
        bool isCorrect = true;

        for (int i = 0; i < password.Length; i++)
        {
            if (Char.IsLetterOrDigit(password[i]) == false)
            {
                isCorrect = false;
            }
        }

        return isCorrect;
    }

    public static bool IsCorrectNumbersOfChars(string password)
    {
        bool isValid = true;

        if (password.Length < 6 || password.Length > 10)
        {
            isValid = false;
        }
        return isValid;

    }
}