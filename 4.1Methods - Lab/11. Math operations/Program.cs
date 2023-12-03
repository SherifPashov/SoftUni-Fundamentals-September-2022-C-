using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char Operation = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = 0;
            switch (Operation)
            {
                case '+':
                    result = operationSum(firstNumber, secondNumber);
                    break;
                case '*':
                    result = operationMultiply(firstNumber, secondNumber);
                    break;
                case '-':
                    result = operationSubtract(firstNumber, secondNumber);
                    break;
                case '/':
                    result = operatinDivide(firstNumber, secondNumber);
                    break;
            }
            Console.WriteLine(result);
        }
        static double  operationSum (double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        static double operationMultiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static double operationSubtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static double operatinDivide(double firstnumber, double secondNumber)
        {
            double result = firstnumber / secondNumber;
            return result;
        }
    }
}
