using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List <int> numberPeopleWagon = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int maxPeopleWagon = int.Parse(Console.ReadLine());

            string[] operation = Console.ReadLine()
                .Split(" ")
                .ToArray();
            while (operation[0]!= "end")
            {

                if (operation.Length > 1)
                {
                    int peopleNuber = int.Parse(operation[1]);
                    numberPeopleWagon.Add(peopleNuber);
                }
                else if (operation.Length == 1)
                {
                    int people = int.Parse(operation[0]); 
                    for (int i = 0; i < numberPeopleWagon.Count; i++)
                    {
                        if (numberPeopleWagon[i] + people <= maxPeopleWagon )
                        {
                            numberPeopleWagon[i]+=people;
                            break;
                        }
                    }
                }

                operation = Console.ReadLine()
                .Split(" ")
                .ToArray();

            }
            Console.WriteLine(String.Join(" ", numberPeopleWagon));
        }
    }
}
