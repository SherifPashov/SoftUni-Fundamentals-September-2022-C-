﻿using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = Area(a, b);
            Console.WriteLine(area);
        }

        static double Area (double a , double b)
        {
            
            return a*b;
        }
    }
}
