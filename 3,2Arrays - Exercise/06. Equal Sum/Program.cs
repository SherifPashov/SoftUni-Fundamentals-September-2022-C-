using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            bool yes = true;
            
                        
            if (num.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            

            for (int i = 1; i < num.Length-1; i++)
            {
                int sumRight = 0;
                int sumLeft = 0;
                
                for (int m = 0; m < i; m++)
                {
                    
                    sumLeft += num[m];

                }

                for (int d =i+1 ; d < num.Length; d++)
                {
                    
                    sumRight += num[d];

                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    yes = false;

                }
            }

            if (num.Length == 1)
            {
                Console.WriteLine("0");
            }
            if (yes)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
