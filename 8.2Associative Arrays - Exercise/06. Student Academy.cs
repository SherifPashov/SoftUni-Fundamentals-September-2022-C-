using System;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLoop = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberLoop; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrade.ContainsKey(name))
                {
                        studentsGrade.Add(name, new List<double>());
                }
                studentsGrade[name].Add(grade);
            }

            foreach (var student in studentsGrade)
            {
                double sumGrades = 0;
                for (int i = 0; i < student.Value.Count; i++)
                {
                    sumGrades += student.Value[i];
                }
                double averageGrade = sumGrades / student.Value.Count;

                if (averageGrade>=4.5)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
                
            }
        }
    }
}
