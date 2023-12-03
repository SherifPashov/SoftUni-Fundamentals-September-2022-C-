using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                char word = char.Parse(Console.ReadLine());
                int number2 = (int)word;
                sum+=number2;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
