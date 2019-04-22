using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main()
        {
            double lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetBroke = Math.Floor(lostGames / 2);
            double mouseBroke = Math.Floor(lostGames / 3);
            double keyboardBroke = Math.Floor(lostGames / 6);
            double displayBroke = Math.Floor(keyboardBroke / 2);

            double sum = (headsetBroke * headsetPrice) + (mouseBroke * mousePrice) +
                (keyboardBroke * keyboardPrice) + (displayBroke*displayPrice);
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}
