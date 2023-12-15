using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberTrue = 0;
            int n = 0;
            while (number > numberTrue)
            {
                n++;
               
                if (n % 2 == 1)
                {
                   Console.WriteLine(n);
                    sum += n;
                    numberTrue++;
                }
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
