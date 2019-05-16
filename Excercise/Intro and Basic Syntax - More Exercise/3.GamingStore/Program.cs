using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            
            double price = 0.00;
            double totalSpent = 0.00;

            while (command != "Game Time")
            {
                  switch (command)
                    {
                        case "OutFall 4":
                            price = 39.99;
                            if (balance >= price)
                            {
                                Console.WriteLine($"Bought {command}");
                                balance -= price;
                                totalSpent += price;
                                command = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                                command = Console.ReadLine();
                            }
                            break;
                        case "CS: OG":
                            price = 15.99;
                            if (balance >= price)
                            {
                                Console.WriteLine($"Bought {command}");
                                 balance -= price;
                                totalSpent += price;
                                command = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                                command = Console.ReadLine();
                            }
                            break;
                        case "Zplinter Zell":
                            price = 19.99;
                            if (balance >= price)
                            {
                                Console.WriteLine($"Bought {command}");
                                balance -= price;
                                totalSpent += price;
                                command = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                                command = Console.ReadLine();
                            }
                            break;
                        case "Honored 2":
                            price = 59.99;
                            if (balance >= price)
                            {
                                Console.WriteLine($"Bought {command}");
                                 balance -= price;
                                totalSpent += price;
                                command = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                                command = Console.ReadLine();
                            }
                            break;
                        case "RoverWatch":
                            price = 29.99;
                            if (balance >= price)
                            {
                                Console.WriteLine($"Bought {command}");
                                balance -= price;
                                totalSpent += price;
                                command = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                                command = Console.ReadLine();
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            price = 39.99;
                            if (balance >= price)
                            {
                                Console.WriteLine($"Bought {command}");
                                balance -= price;
                                totalSpent += price;
                                command = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                                command = Console.ReadLine();
                            }
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            command = Console.ReadLine();
                            break;
                    }
                
               
            }
            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2} ");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
