using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students
{
    class Program
    {
        static void Main()
        {
            List<Studens> studentsInfo = new List<Studens>();

            string[] command = Console.ReadLine().Split();

            while (command[0]!= "end")
            {
                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string hometown = command[3];

                Studens student = new Studens()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };
                studentsInfo.Add(student);

                command = Console.ReadLine().Split();
            }
            string city = Console.ReadLine();

            List<Studens> studentsInThatCity = studentsInfo.Where(x => x.Hometown == city).ToList();

            foreach (var student in studentsInThatCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }

    class Studens
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
