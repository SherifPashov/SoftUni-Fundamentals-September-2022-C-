﻿using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double grades = double.Parse(Console.ReadLine());
            Grades(grades);

        }
        static void Grades(double grades)
        {
            if (grades >=2 && grades <=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3 && grades <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grades >= 3.5 && grades <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grades >= 4.5 && grades <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grades >= 5.5 && grades <=6 )
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Invalid grade");
            }
        }
    }
}
