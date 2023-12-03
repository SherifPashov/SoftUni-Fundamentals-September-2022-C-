using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2(\1)\d{3}(\1)\d{4}\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);
            Console.WriteLine(String.Join(", ",matchCollection));
        }
    }
}
