using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string words = Console.ReadLine();
            while (words != "end")
            {
                string[] studentAray = words.Split(' ');
                string name = studentAray[0];
                string lastName = studentAray[1];
                string age = studentAray[2];
                string citi = studentAray[3];
                bool any = true;
                foreach (Student sudent in students)
                {
                    if (sudent.Name == name && sudent.LastName == lastName)
                    {
                        any = false;
                        sudent.Age = age;
                        sudent.City = citi;
                        break;
                    }
                }
                if (any)
                {
                    Student student = new Student(name, lastName, age, citi);
                    students.Add(student);
                    
                }
                words = Console.ReadLine();

            }
            string cityOfStudent = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                if (currentStudent.City == cityOfStudent)
                {
                    Console.WriteLine($"{currentStudent.Name} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
        public class Student
        {
            public Student(string name, string lastName, string age, string sity)
            {

                Name = name;
                LastName = lastName;
                Age = age;
                City = sity;
            }

            public string Name { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string City { get; set; }
        }
    }
}
