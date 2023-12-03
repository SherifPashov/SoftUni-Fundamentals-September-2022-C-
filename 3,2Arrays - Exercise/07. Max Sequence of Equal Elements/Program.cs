using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int maxPosledovatelnost=0;
            int position = 0;
                                                        //2 1 1 2 3 3 2 2 2 1   2 2 2
            for (int i = 0; i < arr.Length; i++)
            {
                int posledovatelnost = 0;
                
                int numberI = arr[i];
                for (int m = i;  m < arr.Length;  m++)
                {
                    int numberM = arr[m];
                    if (numberI != numberM)
                    {
                        break;
                    }
                    posledovatelnost++;

                }
                if (maxPosledovatelnost < posledovatelnost)
                {
                    maxPosledovatelnost = posledovatelnost;
                    position = i;

                }

            }
            for (int m = 1; m <= maxPosledovatelnost; m++)
            {
                Console.Write($"{arr[position]} ");
            }

        }
    }
}
