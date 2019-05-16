using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main()
        {
            int snowballsNum = int.Parse(Console.ReadLine());
            // тъй като ще приссвоява по - долу полученото голямо число
            BigInteger highestSnowballValue = 0;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;

            for (int i = 0; i < snowballsNum; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                // тъй като е на степен числото става ммного голямо
                BigInteger valueOfTheSnowball = BigInteger.Pow((snow/time), quality);

                if (valueOfTheSnowball > highestSnowballValue) 
                {
                    highestSnowballValue = valueOfTheSnowball;
                    highestSnow = snow;
                    highestTime = time;
                    highestQuality = quality;
                    
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestSnowballValue} ({highestQuality})");
        }
    }
}
