using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            Dictionary< string, List<string>> courses = new Dictionary< string, List<string>>();

            while (input != "end")
            {
                string[] info = input
                    .Split(" : ")
                    .ToArray();
                string cours = info[0];
                string student = info[1];
                if (!courses.ContainsKey(cours))
                {
                    courses.Add(cours, new List<string>());
                   
                }
                courses[cours].Add(student);


                input = Console.ReadLine();
            }
            foreach (var (key,value) in courses)
            {
                Console.WriteLine($"{key}: {value.Count}");
                for (int i = 0; i < value.Count; i++)
                {
                    Console.WriteLine($"-- {value[i]}");
                }
            }
        }
    }
}
