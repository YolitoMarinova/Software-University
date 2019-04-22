using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main()
        {
            string firstCommand = Console.ReadLine();

            double coinsSum = 0.00;

            while (firstCommand != "Start")
            {
                double coins = double.Parse(firstCommand);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    coinsSum += coins;
                    firstCommand = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {firstCommand}");
                    firstCommand = Console.ReadLine();
                }                
            }

            string products = Console.ReadLine();

            double price = 0.00;
            

            while (products != "End")
            {
                if (products == "Nuts")
                {
                    price = 2.0;
                    if (coinsSum >= price)
                    {
                        Console.WriteLine($"Purchased {products.ToLower()}");
                        coinsSum = coinsSum - price;
                        products = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        products = Console.ReadLine();
                    }
                }
                else if (products == "Water")
                {
                    price = 0.7;
                    if (coinsSum >= price)
                    {
                        Console.WriteLine($"Purchased {products.ToLower()}");
                        coinsSum = coinsSum - price;
                        products = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        products = Console.ReadLine();
                    }
                }
                else if (products == "Crisps")
                {
                    price = 1.5;
                    if (coinsSum >= price)
                    {
                        Console.WriteLine($"Purchased {products.ToLower()}");
                        coinsSum = coinsSum - price;
                        products = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        products = Console.ReadLine();
                    }
                }
                else if (products == "Soda")
                {
                    price = 0.8;
                    if (coinsSum >= price)
                    {
                        Console.WriteLine($"Purchased {products.ToLower()}");
                        coinsSum = coinsSum - price;
                        products = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        products = Console.ReadLine();
                    }
                }
                else if (products == "Coke")
                {
                    price = 1.0;
                    if (coinsSum >= price)
                    {
                        Console.WriteLine($"Purchased {products.ToLower()}");
                        coinsSum = coinsSum - price;
                        products = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        products = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    products = Console.ReadLine();
                }
            }

            Console.WriteLine($"Change: {coinsSum:F2}");

        }
    }
}
