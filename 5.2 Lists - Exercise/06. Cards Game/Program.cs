using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> card1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> card2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (card1[0] > card2[0])
                {
                    card1.Add(card1[0]);
                    card2.Add(card2[0]);
                }
                else if (card1[0] < card2[0])
                {
                    card1.Add(card2[0]);
                    card2.Add(card1[0]);
                }

                card1.Remove(card1[0]);
                card2.Remove(card2[0]);

                if (card1.Count == 0)
                {
                    int sum = card2.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;

                }
                else if (card2.Count == 0)
                {
                    int sum = card1.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
               
        }
    }
}
