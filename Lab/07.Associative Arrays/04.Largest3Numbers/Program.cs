using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
