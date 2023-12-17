using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            int multy = int.Parse(Console.ReadLine());
            if (multy == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int firstNumber = 0;
            var sub = new StringBuilder();
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(numberString[i].ToString());
                int result = number * multy + firstNumber;
                int last = result % 10;
                
                sub.Insert(0,last);
                firstNumber = result / 10;
                
            }
            if (firstNumber>0)
            {
                sub.Insert(0, firstNumber);
            }

           
            Console.WriteLine(string.Join("",sub));
        }
    }
}
