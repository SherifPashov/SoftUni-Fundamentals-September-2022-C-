using System;
using System.Text;

namespace Problem_1___The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            string cmd;

            while ((cmd = Console.ReadLine())!="Decode")
            {
                string[] comandinfo = cmd.Split('|');
                string comand = comandinfo[0];
                if (comand == "Move")
                {
                   int numberOfLetters = int.Parse(comandinfo[1]);
                    for (int i = 0; i < numberOfLetters; i++)
                    {
                        input.Append(input[i]);
                    }
                    input.Remove(0, numberOfLetters);
                }
                else if (comand == "Insert")
                {
                    int index = int.Parse(comandinfo[1]);
                    string value = comandinfo[2];
                    input.Insert(index, value);
                }
                else if (comand == "ChangeAll")
                {
                    string substring = comandinfo[1];
                    string replacement = comandinfo[2];
                    input.Replace(substring,replacement);
                }

            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
