using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List <string> list = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
