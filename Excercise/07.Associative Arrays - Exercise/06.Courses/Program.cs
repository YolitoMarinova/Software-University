using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(" : ");

            var courses = new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                string courseName = input[0];
                string studentName = input[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

                input = Console.ReadLine().Split(" : ");
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                course.Value.Sort();
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
