using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
            }

            foreach (var student in students)
            {
                double sum = student.Value.Sum();
                int countOfGrade = student.Value.Count;

                student.Value[0] = sum / countOfGrade;
            }



            foreach (var student in students.Where(x => x.Value[0] >= 4.50).OrderByDescending(x => x.Value[0]))
            {

                Console.WriteLine($"{student.Key} -> {student.Value[0]:F2}");
            }
        }
    }
}
