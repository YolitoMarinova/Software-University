using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main()
        {
            byte row = byte.Parse(Console.ReadLine());
            byte volume = Byte.MaxValue;
            int litersInTank= 0;

            for (int i = 0; i < row; i++)
            {
                int incomingLitters = int.Parse(Console.ReadLine());

                if (litersInTank+incomingLitters<=volume)
                {
                    litersInTank += incomingLitters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litersInTank);
        }
    }
}
