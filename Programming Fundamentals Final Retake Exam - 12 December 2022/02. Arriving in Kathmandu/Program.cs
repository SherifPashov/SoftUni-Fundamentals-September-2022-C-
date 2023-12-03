using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<nameOfpeak>[A-Za-z0-9!@#$?]+)=(?<Length>\d+)<<(?<Code>(.*?)+)$";
            string input;
            Regex regex = new Regex(pattern);
            while ((input = Console.ReadLine()) != "Last note")
            {
                Match match = regex.Match(input);
                if (match.Success == false)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                string nameOfPeak = match.Groups["nameOfpeak"].Value;
                int length = int.Parse(match.Groups["Length"].Value);
                string code = match.Groups["Code"].Value;
                string nameOfPeakResult = string.Empty;
                if (code.Length != length)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                for (int i = 0; i < nameOfPeak.Length; i++)
                {
                    if (char.IsLetterOrDigit(nameOfPeak[i]))
                    {
                        nameOfPeakResult += nameOfPeak[i];
                    }
                }

                Console.WriteLine($"Coordinates found! {nameOfPeakResult} -> {code}");
            }
        }
    }
}