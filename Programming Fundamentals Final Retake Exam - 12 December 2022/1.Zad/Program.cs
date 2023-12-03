using System;
using System.IO;

namespace _1.Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = null;
            while ((input=Console.ReadLine())!= "Registration")
            {
                string[] info = input.Split(' ');
                string comand = info[0];

                if (comand == "Letters")
                {
                    string type = info[1];
                    if (type == "Lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if (type == "Upper")
                    {
                        username=username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if (comand == "Reverse")
                {
                    int startIndex = int.Parse(info[1]);
                    int endIndex = int.Parse(info[2]);

                    if (startIndex>=0 && endIndex<username.Length)
                    {
                        char[] charakter = username.ToCharArray();
                        for (int i = endIndex; i >= startIndex; i--)
                        {
                            Console.Write(charakter[i]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (comand == "Substring")
                {
                    string substring = info[1];
                    if (username.Contains(substring))
                    {
                        username = username.Replace(substring,"");
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The username {username} doesn't contain {substring}.");
                    }
                }
                else if (comand == "Replace")
                {
                    string charakter = info[1];
                    username = username.Replace(charakter, "-");
                    Console.WriteLine(username);
                }
                else if (comand == "IsValid")
                {
                    string charakter = info[1];
                    if (username.Contains(charakter))
                    {
                        Console.WriteLine("Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{charakter} must be contained in your username.");
                    }
                }
            }
        }
    }
}
