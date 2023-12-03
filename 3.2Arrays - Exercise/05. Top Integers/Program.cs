using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int position = 0;
            int max = int.MinValue;
            for (int i = 0; i < number.Length; i++)
            {
                bool topIntiger = true;
                
                int backnNumber = number[i];
                for (int k = i+1;  k < number.Length;  k++)
                {
                    int nextNum = number[k];
                    if (nextNum >= backnNumber)
                    {
                        topIntiger = false;
                        break;

                    }
                }
                if (topIntiger)
                {
                    Console.Write(backnNumber+ " ");

                }

            }
           
            
        }
    }
}
