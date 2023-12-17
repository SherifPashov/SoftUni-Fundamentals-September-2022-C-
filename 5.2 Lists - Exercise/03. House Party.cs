using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string[] comand = Console.ReadLine()
                    .Split()
                    .ToArray();
                string name = comand[0];
                if (comand.Length == 3)
                {
                    if (list.Any(x=> x == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        list.Add(name);
                    }

                }
                else if (comand.Length == 4) 
                {
                    if (list.Any(x => x == name))
                    {
                        list.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
