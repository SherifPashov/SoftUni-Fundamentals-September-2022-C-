using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> listNumber = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string[] comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            while (comand[0]!= "End")
            {
                string operation = comand[0];
                int number = 0;
                if (operation == "Add")
                {
                    number = int.Parse(comand[1]);

                    listNumber.Add(number);
                }
                else if (operation == "Insert")
                {
                    number = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    if (index>=0 && index < listNumber.Count)
                    {
                        listNumber.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (operation == "Remove")
                {

                    number = int.Parse(comand[1]);
                    if (number >= 0 && number < listNumber.Count)
                    {
                        listNumber.RemoveAt(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (operation == "Shift")
                {
                    string leftOrRight = comand[1];
                    int numberLoop = int.Parse(comand[2]);
                    if (leftOrRight == "left")
                    {
                        for (int i = 0; i < numberLoop; i++)
                        {
                            ShifLeft(listNumber);
                        }
                    }
                    else if (leftOrRight == "right")
                    {
                        for (int i = 0; i < numberLoop; i++)
                        {
                            ShifRight(listNumber);
                        }
                        

                    }
                }

                comand = Console.ReadLine()
                .Split(" ")
                .ToArray();
            }
            Console.WriteLine(String.Join(" ", listNumber));
          
        }

        private static void ShifRight(List<int> listNumber)
        {
            int last = listNumber[listNumber.Count-1];
            for (int n = listNumber.Count - 1; n >= 1; n--)
            {
                listNumber[n] = listNumber[n - 1];
            }
            listNumber[0] = last;
        }

        private static void ShifLeft(List<int> listNumber)
        {
            int first = listNumber[0];
            for (int n = 0; n < listNumber.Count - 1; n++)
            {
                listNumber[n] = listNumber[n + 1];
            }
            listNumber[listNumber.Count - 1] = first;
        }
    }
}
