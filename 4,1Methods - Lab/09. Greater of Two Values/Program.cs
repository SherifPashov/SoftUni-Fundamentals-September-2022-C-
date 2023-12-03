using System;
using System.Runtime.ExceptionServices;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type  = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(first);
                    int secondInt = int.Parse(second);
                    int resultInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(first);
                    char secondChar = char.Parse(second);
                    char resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string result =GetMax(first, second);
                    Console.WriteLine(result);
                    break;
            }

        }

        static int GetMax( int a,int b )
        {
            if (a > b)
            {
                return a;
            }
            return b;
            
        }
        static char GetMax(char a , char b)
        {
            int aResult = (int)a;
            int bResult = (int)b;
            if (aResult > bResult)
            {
                return a;
            }
            return b;
        }
        static string GetMax(string a , string b)
        {
            //int sumA = 0;
            //int sumB = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    sumA += (int)a[i];
            //}

            //for (int i = 0; i < b.Length; i++)
            //{
            //    sumB += (int)b[i];
            //}

            //if (sumA >= sumB)
            //{
            //    return a;
            //}
            //return b;
            int result = a.CompareTo(b);
            if (result>0)
            {
                return a;
            }
            return b;
        }
        


    }
}
