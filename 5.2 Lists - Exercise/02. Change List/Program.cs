using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string[] comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            while (comand[0] != "end")
            {
                if (comand[0] == "Delete")
                {
                    int numberDelete = int.Parse(comand[1]);
                    number.RemoveAll(x => x == numberDelete);
                }
                else if (comand[0] == "Insert")
                {
                    int element = int.Parse(comand[1]);
                    int position = int.Parse(comand[2]);
                    number.Insert(position, element);
                }
                comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            }
            Console.WriteLine(String.Join(" ", number));
                
        }
    }
}
