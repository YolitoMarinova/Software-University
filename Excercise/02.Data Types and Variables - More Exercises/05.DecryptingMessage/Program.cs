using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            string decryptedWord ="";

            for (int i = 0; i < row; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char newCharacter =(char)(character + key);
                decryptedWord += newCharacter;
            }
            Console.WriteLine(decryptedWord);
        }
    }
}
