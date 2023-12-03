using System;

namespace _07._Concat_Names
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
                if (i == 1)
                {
                    Console.Write(a);
                }
                else if (i == 2)
                {
                    Console.Write(c);
                }
                else if (i == 3)
                {
                    Console.Write(b);
                }
            }
        }
    }
}
