using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split();

            Array.Reverse(array);
            Console.WriteLine(string.Join(" ",array));
            
           
        }
    }
}
