using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arry = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int number1 = int.Parse(Console.ReadLine());
            int number = number1 % arry.Length-1;
            for (int i = 0; i <= number; i++)
            {
                int numberOne = arry[0];
                for (int ki = 1; ki <= arry.Length-1; ki++)
                {
                    arry[ki-1] = arry[ki];
                   
                }
                arry[arry.Length - 1] = numberOne;
            }
            Console.WriteLine(String.Join(" ",arry));
        }
    }
}
