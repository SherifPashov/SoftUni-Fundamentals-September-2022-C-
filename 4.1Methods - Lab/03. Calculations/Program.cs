using System;
using System.Diagnostics;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operaion = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            double secondNumber =  double.Parse(Console.ReadLine());

            if (operaion == "add")
            {
                Add(number, secondNumber);
            }
            else if (operaion == "multiply")
            {
                Multiply(number, secondNumber);
            }
            else if (operaion == "subtract")
            {
                Subtract(number, secondNumber);
            }
            else if (operaion == "divide")
            {
                Divide(number, secondNumber);
            }
        }

        static void Add ( double number, double secondNumber)
        {
            Console.WriteLine(number+secondNumber);
        }

        static void Multiply (double number, double secondNumber)
        {
            Console.WriteLine(number*secondNumber);
        }

        static void Subtract (double number, double secondNumber)
        {
            Console.WriteLine(number - secondNumber);
        }
        static void Divide (double number, double secondNumber)
        {
            Console.WriteLine(number / secondNumber);
        }
    }
}
