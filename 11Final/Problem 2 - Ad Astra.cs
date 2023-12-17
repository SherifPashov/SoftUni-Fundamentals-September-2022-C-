using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(#|\|)(?<name>[A-Za-z ]+)\1(?<data>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
            Regex regex = new Regex(patern);
            int allCalories = 0;

            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);
            if (matchCollection.Count > 0)
            {
                foreach (Match item in matchCollection)
                {
                    string name = item.Groups["name"].Value;
                    string data = item.Groups["data"].Value;
                    int calories = int.Parse(item.Groups["calories"].Value);
                    allCalories+=calories;
                    
                }
                int days = allCalories / 2000;
                Console.WriteLine($"You have food to last you for: {days} days!");
                foreach (Match item in matchCollection)
                {
                    string name = item.Groups["name"].Value;
                    string data = item.Groups["data"].Value;
                    int calories = int.Parse(item.Groups["calories"].Value);
                    allCalories += calories;
                    Console.WriteLine($"Item: {name}, Best before: {data}, Nutrition: {calories}");
                }

                
            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
        }
    }
}
