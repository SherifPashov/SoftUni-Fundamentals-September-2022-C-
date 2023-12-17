using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string[] comand =Console.ReadLine()
                .Split(" ")
                .ToArray();
            while (comand[0]!="end")
            {
                string operation = comand[0];
                int numberOperatin = int.Parse(comand[1]);
                if (operation == "Add")
                {
                    number.Add(numberOperatin);
                }
                else if (operation == "Remove")
                {
                    number.Remove(numberOperatin);
                }
                else if (operation == "RemoveAt")
                {
                    number.RemoveAt(numberOperatin);
                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(comand[2]);
                    number.Insert(index, numberOperatin);
                }

                comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            }
            Console.WriteLine(String.Join(" ",number));
        }
    }
}
