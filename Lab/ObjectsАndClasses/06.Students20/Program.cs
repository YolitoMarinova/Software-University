using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Students20
{
    class Program
    {
        static void Main()
        {
            List<Studens> studentsInfo = new List<Studens>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string hometown = command[3];

                if (!IsStudentExist(studentsInfo, firstName, lastName))
                {
                    Studens student = new Studens()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };
                    studentsInfo.Add(student);
                }
                else
                {
                    Studens student = GetStudent(studentsInfo, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;
                }



                command = Console.ReadLine().Split();
            }
            string city = Console.ReadLine();

            List<Studens> studentsInThatCity = studentsInfo.Where(x => x.Hometown == city).ToList();

            foreach (var student in studentsInThatCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        private static Studens GetStudent(List<Studens> studentsInfo, string firstName, string lastName)
        {
            Studens existingStuednt = null;

            foreach (var student in studentsInfo)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStuednt = student;
                }
            }

            return existingStuednt;
        }

        private static bool IsStudentExist(List<Studens> studentsInfo, string firstName, string lastName)
        {
            foreach (var student in studentsInfo)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
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
