using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                int serialNumber = int.Parse(command[0]);
                string name = command[1];
                int quantity = int.Parse(command[2]);
                decimal price = decimal.Parse(command[3]);
                decimal priceOfBox = quantity * price;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.Item.Name = name;
                box.ItemQuantity = quantity;
                box.Item.Price = price;
                box.PriceOfBox = priceOfBox;

                boxes.Add(box);

                command = Console.ReadLine().Split();
            }

            var descendingBoxes = boxes.OrderByDescending(x => x.PriceOfBox).ToList();

            foreach (var box in descendingBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceOfBox:F2}");
            }

        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
          Item = new Item();
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceOfBox { get; set; }
    }
}
