using System;
using System.Collections.Generic;
using System.Linq;

namespace _3zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string firstGroup =null;
            int count = 0;
            Dictionary<string, List<string>> bandNameMember = new Dictionary<string, List<string>>();
            Dictionary<string,int> bandNameTime = new Dictionary<string, int>();
            
            while ((input=Console.ReadLine())!="Start!")
            {
                string[] info = input.Split("; ");
                string comand = info[0];
                string bandName = info[1];

                string[] bandMembers = info[2].Split(", ").ToArray();
                if (comand == "Add")
                {
                    if (!bandNameMember.ContainsKey(bandName))
                    {
                        bandNameMember[bandName] = new List<string>();
                    }

                    for (int i = 0; i < bandMembers.Length; i++)
                    {
                        if (!bandNameMember[bandName].Contains(bandMembers[i]))
                        {
                            bandNameMember[bandName].Add(bandMembers[i]);
                        }
                    }
                }
                else if (comand == "Play")
                {
                    if (!bandNameTime.ContainsKey(bandName))
                    {
                        bandNameTime[bandName] = 0;
                    }
                    if (count==0)
                    {
                        firstGroup = bandName;
                    }
                    bandNameTime[bandName]+= int.Parse(info[2]);
                    count++;
                }

            }
            int totalTime = 0;
            foreach (var (key,value) in bandNameTime)
            {
                totalTime+=value;
            }
            Console.WriteLine($"Total time: {totalTime}");

            foreach (var (name, time) in bandNameTime)
            {
                Console.WriteLine($"{name} -> {time}");
            }
            List<string> firstMember = new List<string>(bandNameMember[firstGroup]);
            Console.WriteLine(firstGroup);
            foreach (var item in firstMember)
            {
                Console.WriteLine($"=> {item}");
            }

        }
    }
}
