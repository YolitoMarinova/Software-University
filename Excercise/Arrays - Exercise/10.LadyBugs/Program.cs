using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main()
        {
            int lenghtOfArray = int.Parse(Console.ReadLine());
            int[] indexOfBugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] bugs = new int[lenghtOfArray];

            for (int i = 0; i < bugs.Length; i++)
            {
                if (indexOfBugs.Contains(i)) bugs[i] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] indexOfFly = command.Split().ToArray();
                int flyingBugsIndex = int.Parse(indexOfFly[0]);
                string direction = indexOfFly[1];
                int landeBugsIndex = int.Parse(indexOfFly[2]);

                if ((flyingBugsIndex >= 0) && (flyingBugsIndex < lenghtOfArray) && (bugs[flyingBugsIndex] == 1))
                {
                    bugs[flyingBugsIndex] = 0;

                    if (direction == "right")
                    {
                        while ((flyingBugsIndex + landeBugsIndex < lenghtOfArray) && (flyingBugsIndex + landeBugsIndex >= 0))
                        {
                            if (bugs[flyingBugsIndex + landeBugsIndex] == 0)
                            {
                                bugs[flyingBugsIndex + landeBugsIndex] = 1;
                                break;
                            }
                            else flyingBugsIndex += landeBugsIndex;
                        }
                    }
                    else if (direction == "left")
                    {
                        while ((flyingBugsIndex - landeBugsIndex >= 0) && (flyingBugsIndex - landeBugsIndex < lenghtOfArray))
                        {
                            if (bugs[flyingBugsIndex - landeBugsIndex] == 0)
                            {
                                bugs[flyingBugsIndex - landeBugsIndex] = 1;
                                break;
                            }
                            else flyingBugsIndex -= landeBugsIndex;
                        }
                    }
                    else flyingBugsIndex -= landeBugsIndex;
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",bugs));
        }
    }
}
