using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\/|\.|\-)(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match item in matchCollection)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
