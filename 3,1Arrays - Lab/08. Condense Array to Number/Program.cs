using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int sumi = nums.Length;
            while (sumi!=1)
            {
                int[] cond = new int[sumi-1];
                sumi = 0;
               

                for (int i = 0; i < nums.Length-1; i++)
                {
                   
                        cond[i] = nums[i] + nums[i+1];
                        sumi++;
                    
                }
                nums = cond;
                

                if (sumi ==1)
                {
                    Console.WriteLine(cond[0]);
                    return;
                }
            }
            if (sumi == 1)
            {
                Console.WriteLine(nums[0]);
            }

        }
    }
}
