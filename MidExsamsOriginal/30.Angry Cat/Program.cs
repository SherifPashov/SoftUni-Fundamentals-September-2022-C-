using System;
using System.Collections.Generic;
using System.Linq;

namespace _30.Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lits = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeItem = Console.ReadLine();

            int maxValuo = lits[entryPoint];
            int sumLeft=0;
            int sumRight=0;
           

            for (int i = entryPoint +1; i < lits.Length; i++)
            {

                if (typeItem == "cheap")
                {
                    if (maxValuo > lits[i])
                    {
                        sumRight+=lits[i];
                    }
                }
                else if (typeItem == "expensive")
                {
                    if (maxValuo <= lits[i])
                    {
                        sumRight += lits[i];
                    }
                }
            }

            for (int m = 0; m < entryPoint; m++)
            {
                if (typeItem == "cheap")
                {
                    if (maxValuo > lits[m])
                    {
                        sumLeft += lits[m];
                    }
                }
                else if (typeItem == "expensive")
                {
                    if (maxValuo <= lits[m])
                    {
                        sumLeft += lits[m];
                    }
                }
            }
            if (sumLeft>sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else if (sumRight>sumLeft)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else if (sumLeft == sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
        }
    }
}
