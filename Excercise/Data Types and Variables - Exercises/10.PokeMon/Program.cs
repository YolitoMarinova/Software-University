using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTarget = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int fiftyPercentPower = pokePower;
            int reachTarget = 0;

            while (pokePower >= distanceBetweenTarget && distanceBetweenTarget!=0)
            {
                pokePower -= distanceBetweenTarget;
                reachTarget++;

                if (fiftyPercentPower*0.5==pokePower && exhaustionFactor!=0)
                {
                    pokePower /= exhaustionFactor;
                }
               
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(reachTarget);
        }
    }
}
