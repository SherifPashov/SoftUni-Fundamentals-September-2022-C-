using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var bandsMembers = new Dictionary<string, List<string>>();
            var bandsTimes = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "Start!")
            {
                List<string> commandList = command.Split("; ").ToList();

                if (commandList[0] == "Add")
                {
                    string[] members = commandList[2].Split(", ");
                    commandList.RemoveAt(2);

                    GetResultByADD(members, commandList, bandsMembers, bandsTimes);
                }
                else if (commandList[0] == "Play")
                {
                    GetResultByPlayCommand(bandsMembers, commandList, bandsTimes);
                }
            }
            PrintResult(bandsTimes, bandsMembers);
        }

        private static void GetResultByADD(string[] members, List<string> commandList, Dictionary<string, List<string>> bandsMembers, Dictionary<string, int> bandsTimes)
        {
            for (int i = 0; i < members.Length; i++)
            {
                commandList.Add(members[i]);
            }


            if (!bandsMembers.ContainsKey(commandList[1]))
            {
                bandsMembers.Add(commandList[1], new List<string>());
                bandsTimes.Add(commandList[1], 0);
            }
            for (int i = 2; i < commandList.Count; i++)
            {
                if (!bandsMembers[commandList[1]].Contains(commandList[i]))
                {
                    bandsMembers[commandList[1]].Add(commandList[i]);
                }
            }
        }

        private static void GetResultByPlayCommand(Dictionary<string, List<string>> bandsMembers, List<string> commandList, Dictionary<string, int> bandsTimes)
        {
            if (!bandsMembers.ContainsKey(commandList[1]))
            {
                bandsMembers.Add(commandList[1], new List<string>());
                bandsTimes.Add(commandList[1], 0);
            }
            bandsTimes[commandList[1]] += int.Parse(commandList[2]);
        }

        private static void PrintResult(Dictionary<string, int> bandsTimes, Dictionary<string, List<string>> bandsMembers)
        {
            string bandToBeWriten = Console.ReadLine();

            Console.WriteLine($"Total time: {bandsTimes.Values.Sum()}");

            foreach (var kvp in bandsTimes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


            Console.WriteLine(bandToBeWriten);

            foreach (var member in bandsMembers[bandToBeWriten])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}