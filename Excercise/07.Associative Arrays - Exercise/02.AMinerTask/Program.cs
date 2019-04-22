using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerТask
{
    class Program
    {
        static void Main()
        {
            var resources = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;
                }
                else
                {
                    resources[input] = quantity;
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
