using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main()
        {
            byte row = byte.Parse(Console.ReadLine());
            double maxVolume = 0;
            string bigger = "";

            for (int i = 0; i < row; i++)
            {
                string modelOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                int heightOfTheKeg = int.Parse(Console.ReadLine());

                double volumeOfTheKeg = Math.PI * Math.Pow(radiusOfTheKeg, 2) * heightOfTheKeg;
                if (volumeOfTheKeg>maxVolume)
                {
                    maxVolume = volumeOfTheKeg;
                    bigger = modelOfTheKeg;
                }
            }
            Console.WriteLine(bigger);
        }
    }
}
