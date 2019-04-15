using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main()
        {
            List<double> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> result = new List<double>();

            int index = 0;

            while (firstList.Count != 0 && secondList.Count != 0)
            {

                if (index % 2 == 0)
                {
                    result.Add(firstList[0]);
                    firstList.RemoveAt(0);
                }
                else
                {
                   result.Add(secondList[0]);
                    secondList.RemoveAt(0);
                }
                index++;
            }

            if (firstList.Count > 0)
            {
                result=result.Concat(firstList).ToList();
            }
            else if (secondList.Count > 0)
            {
                result=result.Concat(secondList).ToList();
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
