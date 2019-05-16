using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)numberOfPeople/capacity);
            Console.WriteLine(courses);
        }
    } 
}
