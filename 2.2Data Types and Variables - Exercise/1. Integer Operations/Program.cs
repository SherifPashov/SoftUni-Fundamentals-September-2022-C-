using System;

namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int plus = first + second;
            int delene = plus / third;
            int multiply = delene * fourth;
            Console.WriteLine(multiply);
        }
    }
}
