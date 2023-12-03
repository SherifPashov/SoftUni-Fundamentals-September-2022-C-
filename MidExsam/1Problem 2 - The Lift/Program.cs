using System;
using System.Linq;

namespace _1Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < arr.Length; i++)
            {
                for (int m = arr[i]; m < 4; m++)
                {
                    if (numberPeople == 0)
                    {
                        break;
                    }
                    arr[i]++;
                    numberPeople--;

                }
                if (numberPeople == 0)
                {
                    break;
                }
            }
            if (numberPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberPeople} people in a queue!");
            }
            else if (numberPeople == 0 && arr.Any(x => x != 4))
            {
                Console.WriteLine($"The lift has empty spots!");
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
