using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] specialWord = Console.ReadLine().Split(", ");

            string paterName = @"[A-Za-z]+";
            Regex regexName = new Regex(paterName);

            string paternNum = @"\d";
            Regex regexNum = new Regex(paternNum);
           

            string input = Console.ReadLine();

            Dictionary<string,int> player=new Dictionary<string,int>();


            while (input != "end of race")
            {
                int km = 0;
                MatchCollection matchesCharName = regexName.Matches(input);
                MatchCollection matchesNum = regexNum.Matches(input);

                string name = String.Join("", matchesCharName);
                if (specialWord.Contains(name))
                {
                    foreach (var num in matchesNum)
                    {
                        km += int.Parse(num.ToString());
                    }

                    if (!player.ContainsKey(name))
                    {
                        player.Add(name, 0);
                    }
                    player[name] += km;
                }
               

                input = Console.ReadLine();
            }


            player = player
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine();
            int counter = 1;

            foreach (var kvp in player)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }




        }
    }
}
