using System;

namespace _05.Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string login = Console.ReadLine();
            int counter = 1;

            while (login != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                login = Console.ReadLine();
                counter++;
                if (counter == 4 && login!=password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }

            if (login == password)
            {
                Console.WriteLine($"User {username} logged in.");
                
            }

            
        }
    }
}
