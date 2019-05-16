using System;

namespace _05.Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int numberOfPurchase = int.Parse(Console.ReadLine());
            PrintTotalPrice(product, numberOfPurchase);
        }

        private static void PrintTotalPrice(string product, int numberOfPurchase)
        {
            switch (product)
            {
                case "coffee":
                    CalcTotalPrice(1.50, numberOfPurchase);
                    break;
                case "water":
                    CalcTotalPrice(1.00, numberOfPurchase);
                    break;
                case "coke":
                    CalcTotalPrice(1.40, numberOfPurchase);
                    break;
                case "snacks":
                    CalcTotalPrice(2.00, numberOfPurchase);
                    break;
            }

        }

        private static void CalcTotalPrice(double price, int numberOfPurchase)
        {
            double totalPrice = price * numberOfPurchase;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
