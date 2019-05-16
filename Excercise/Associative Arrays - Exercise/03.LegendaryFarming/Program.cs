using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            var legendaryItems = new Dictionary<string, int>();

            legendaryItems.Add("shards", 0);
            legendaryItems.Add("fragments", 0);
            legendaryItems.Add("motes", 0);

            var junkItems = new Dictionary<string, int>();

            var winnerItem = String.Empty;

            bool haveWinner = false;

            while (!haveWinner)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1];

                    if (legendaryItems.ContainsKey(item))
                    {
                        legendaryItems[item] += quantity;
                        if (legendaryItems[item] >= 250)
                        {
                            winnerItem = item;
                            legendaryItems[item] -= 250;
                            haveWinner = true;
                            break;
                        }
                    }
                    else if (junkItems.ContainsKey(item))
                    {
                        junkItems[item] += quantity;
                    }
                    else
                    {
                        junkItems[item] = quantity;
                    }
                    i++;
                }

                if (haveWinner)
                {
                    break;
                }


            }

            switch (winnerItem)
            {
                case "shards":
                    winnerItem = "Shadowmourne";
                    break;
                case "fragments":
                    winnerItem = "Valanyr";
                    break;
                case "motes":
                    winnerItem = "Dragonwrath";
                    break;
            }

            Console.WriteLine($"{winnerItem} obtained!");

            foreach (var item in legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
