using System;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0);

            Console.WriteLine(String.Join(Environment.NewLine,words));
        }
    }
}
