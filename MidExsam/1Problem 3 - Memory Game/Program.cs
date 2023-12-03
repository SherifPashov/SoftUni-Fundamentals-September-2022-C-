using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Problem_3___Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> memory = Console.ReadLine()
                 .Split(" ")
                 .ToList();
            string[] operation = Console.ReadLine()
                .Split(" ")
                .ToArray();
            int movie = 0;

            while (operation[0] != "end")
            {
                int index1 = int.Parse(operation[0]);
                int index2 = int.Parse(operation[1]);
                movie++;
                if (index1 == index2 || index1 < 0 || index2 < 0 || index1 > memory.Count - 1 || index2 > memory.Count - 1)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int sreda = (int)memory.Count / 2;
                    string a = "-" + movie + "a";
                    memory.Insert(sreda, a);
                    memory.Insert(sreda, a);
                    operation = Console.ReadLine()
                   .Split(" ")
                    .ToArray();
                    continue;

                }
                if (memory[index1] == memory[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {memory[index1]}!");
                    if (index1 > index2)
                    {
                        memory.RemoveAt(index1);
                        memory.RemoveAt(index2);
                    }
                    else
                    {
                        memory.RemoveAt(index2);
                        memory.RemoveAt(index1);
                    }

                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (memory.Count == 1)
                {
                    Console.WriteLine($"You have won in {movie} turns!");
                    return;
                }
                else if (memory.Count == 0)
                {
                    Console.WriteLine($"You have won in {movie} turns!");
                    return;
                }

                operation = Console.ReadLine()
                .Split(" ")
                .ToArray();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", memory));
        }
    }
}
