using System;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            for (int i = 1; i <= 3; i++)
            {
                if (i==1)
                {
                    Console.Write(c +" ");
                }
                else if (i==2)
                {
                    Console.Write(b + " ");
                }
                else if (i==3)
                {
                    Console.Write(a);
                }
            }
        }
    }
}
