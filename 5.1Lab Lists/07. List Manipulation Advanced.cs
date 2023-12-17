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
            string[] comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            int changes = 0;
            while (comand[0] != "end")
            {
                string operation = comand[0];
                int numberOperatin = 0;
                if (operation == "Add")
                {
                    numberOperatin = int.Parse(comand[1]);
                    number.Add(numberOperatin);
                    changes++;
                }
                else if (operation == "Remove")
                {
                    numberOperatin = int.Parse(comand[1]);
                    number.Remove(numberOperatin);
                    changes++;
                }
                else if (operation == "RemoveAt")
                {
                    numberOperatin = int.Parse(comand[1]);
                    number.RemoveAt(numberOperatin);
                    changes++;
                }
                else if (operation == "Insert")
                {
                    numberOperatin = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    number.Insert(index, numberOperatin);
                    changes++;
                }
                else if (operation == "Contains")
                {
                    numberOperatin = int.Parse(comand[1]);
                    if (number.Contains(numberOperatin))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (operation == "PrintEven")
                {
                    PrintEvven(number);
                }
                else if (operation == "PrintOdd")
                {
                    PrintOdd(number);
                }
                else if (operation == "GetSum")
                {
                    GetSum(number);
                }
                else if (operation == "Filter")
                {

                    int numberCum=int.Parse(comand[2]);
                    switch (comand[1])
                    {
                        case ">":
                            Console.WriteLine(String.Join(" ", number.Where(x => x > numberCum)));
                            break;
                        case "<":
                            Console.WriteLine(String.Join(" ", number.Where(x => x < numberCum)));
                            break;
                        case ">=":
                            Console.WriteLine(String.Join(" ", number.Where(x => x >= numberCum)));
                            break;
                        case "<=":
                            Console.WriteLine(String.Join(" ", number.Where(x => x <= numberCum)));
                            break;

                    }
                }


                comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            }
            if (changes>0)
            {
                Console.WriteLine(String.Join(" ", number));
            }
            
        }

        private static void GetSum(List<int> number)
        {
            int sum = 0;
            for (int i = 0; i < number.Count; i++)
            {
                sum += number[i];
            }
            Console.WriteLine(sum);
        }

        private static void PrintOdd(List<int> number)
        {
            List<int> printOdd = new List<int>();
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] % 2 == 1)
                {
                    printOdd.Add(number[i]);
                }
            }
            Console.WriteLine(String.Join(" ", printOdd));
        }

        private static void PrintEvven(List<int> number)
        {
            List<int> printEven = new List<int>();
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] % 2 == 0)
                {
                    printEven.Add(number[i]);
                }
            }
            Console.WriteLine(String.Join(" ", printEven));
        }
    }
}
