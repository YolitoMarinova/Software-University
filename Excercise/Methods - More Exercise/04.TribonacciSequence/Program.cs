using System;
using System.Collections.Generic;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main()
        {
            int fibonachi = int.Parse(Console.ReadLine());

            int previous = 0;
            int next = 1;
            int secondNext = 1;

            List<int> results = new List<int> { next, secondNext };

            if (fibonachi > 3)
            {

                for (int i = 0; i < fibonachi - 2; i++)
                {
                    results.Add(previous + next + secondNext);
                    previous = next;
                    next = secondNext;
                    secondNext = results[results.Count-1];
                    
                }
                Console.WriteLine(String.Join(" ",results));
            }
            else if (fibonachi == 2)
            {
                Console.WriteLine(String.Join(" ",results));
            }
            else if (fibonachi == 1)
            {
                Console.Write(1);
                
            }
           
        }
    }
}
