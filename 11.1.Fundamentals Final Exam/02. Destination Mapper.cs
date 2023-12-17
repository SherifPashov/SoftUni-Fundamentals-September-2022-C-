using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(=|\/)[A-Z][A-Za-z]{2,}\1";
            Regex regex = new Regex(patern);
            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);
            int sum = 0;
            List<string> list = new List<string>();

            foreach (Match item in matchCollection)
            {
                string name = "";
                for (int i = 1; i < item.Value.Length-1; i++)
                {
                    name+=item.Value[i].ToString();
                }
                list.Add(name);
                sum+=int.Parse(item.Length.ToString())-2;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {sum}");
            
        }
    }
}
