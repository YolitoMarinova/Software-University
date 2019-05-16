using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main()
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            var vechicles = new Dictionary<string, string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                var command = Console.ReadLine().Split();

                string username;

                switch (command[0])
                {
                    case "register":
                        username = command[1];
                        string plateNumber = command[2];

                        if (!vechicles.ContainsKey(username))
                        {
                            vechicles.Add(username, plateNumber);
                            Console.WriteLine($"{username} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        username = command[1];

                        if (vechicles.ContainsKey(username))
                        {
                            vechicles.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                }
            }

            foreach (var kvp in vechicles)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
