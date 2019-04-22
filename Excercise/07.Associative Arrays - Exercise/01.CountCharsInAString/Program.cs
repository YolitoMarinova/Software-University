using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main()
        {
            /* Write a program that counts all characters in a string except for space (&#39; &#39;).
            Print all the occurrences in the following format:
            {char} -&gt; {occurrences} */

            //text

            /*t -&gt; 2
            e - &gt; 1
            x - &gt; 1*/

            char[] letters = Console.ReadLine().Where(x => x != ' ').ToArray();

            var counts = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (counts.ContainsKey(letter))
                {
                    counts[letter]++;
                }
                else
                {
                    counts[letter] = 1;
                }
            }

            foreach (var letter in counts)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
