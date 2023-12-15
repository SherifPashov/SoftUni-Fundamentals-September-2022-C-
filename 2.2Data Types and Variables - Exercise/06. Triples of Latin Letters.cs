using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int first = 97; first < number + 97; first++)
            {
                for (int second = 97; second < number + 97;second ++)
                {
                    for (int tirth = 97; tirth < number + 97; tirth++)
                    {
                        char firstChar = (char)first;
                        char secondChar = (char)second;
                        char tirthChar = (char)tirth;
                        Console.WriteLine($"{firstChar}{secondChar}{tirthChar}");
                    }
                    
                }
                
            }
        }
    }
}
