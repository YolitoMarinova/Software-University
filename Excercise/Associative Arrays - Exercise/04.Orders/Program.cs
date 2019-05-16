using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main()
        {
            var productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var products = new Dictionary<string, List<decimal>>();



            while (productInfo[0] != "buy")
            {
                string name = productInfo[0];
                decimal price = decimal.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (products.ContainsKey(name))
                {
                    foreach (var item in products)
                    {
                        if (item.Key == name)
                        {
                            item.Value[0] = price;
                            item.Value[1] += quantity;
                        }
                    }
                }
                else
                {
                    products.Add(name, new List<decimal>());
                    products[name].Add(price);
                    products[name].Add(quantity);

                }

                productInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var product in products)
            {
                decimal totalPrice = product.Value[0] * product.Value[1];

                Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
            }
        }
    }
}
