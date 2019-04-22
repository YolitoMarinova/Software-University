using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            var students = new Dictionary<string, int>();
            var sumbissions = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split("-");

            while (input[0] != "exam finished")
            {
                string name = input[0];

                if (input[1] == "banned")
                {
                    students.Remove(name);
                }
                else
                {
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    if (students.ContainsKey(name))
                    {
                        if (points > students[name])
                        {
                            students[name] = points;
                        }
                    }
                    else
                    {
                        students[name] = points;
                    }

                    if (!sumbissions.ContainsKey(language))
                    {
                        sumbissions[language] = 0;
                    }
                    sumbissions[language]++;
                }

                input = Console.ReadLine().Split("-");
            }

            Console.WriteLine("Results:");
            foreach (var kvp in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in sumbissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
