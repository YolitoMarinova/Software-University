﻿using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());
            double volume = (length*width*heigth)/3;
            Console.Write($"Pyramid Volume: {volume:F2}");
        }
    }
}
