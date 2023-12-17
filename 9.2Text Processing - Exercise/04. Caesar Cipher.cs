using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (var currChar in input)
            {
                int numberChar = currChar + 3;
                sb.Append((char)numberChar);

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
