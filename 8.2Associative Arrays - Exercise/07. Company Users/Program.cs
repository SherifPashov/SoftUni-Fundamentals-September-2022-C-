using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            Dictionary<string,List<string>> nameId = new Dictionary<string,List<string>>();

            while (input != "End")
            {
                string[] info = input
                    .Split(' ');
                string companyName = info[0];
                string peopleId = info[2];


                if (!nameId.ContainsKey(companyName))
                {
                    nameId.Add(companyName, new List<string>());
                }

                bool anyId = nameId[companyName].Contains(peopleId);
                if (!anyId)
                {
                    nameId[companyName].Add(peopleId);
                }

                input = Console.ReadLine();
            }

            foreach (var (name,id) in nameId)
            {
                Console.WriteLine(name);
                for (int i = 0; i < id.Count; i++)
                {
                    Console.WriteLine($"-- {id[i]}");
                }
            }
        }
    }
}
