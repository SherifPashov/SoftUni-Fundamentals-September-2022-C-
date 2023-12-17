using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var bomb = new StringBuilder(input);
            int bonusBumb = 0;

            for (int i = 0; i < bomb.Length; i++)           //abv>1>1>2>2asdasd
            {
                if (bomb[i]== '>')
                {
                    int pawer = int.Parse(bomb[i + 1].ToString());

                    int r = pawer + bonusBumb;
                    for (int p = 0; p < r; p++)
                    {
                        if (i+1<bomb.Length)
                        {
                            if (bomb[i + 1] != '>')
                            {
                                bomb.Remove((i + 1), 1);
                            }
                            else
                            {
                                bonusBumb++;
                                break;
                            }
                            bonusBumb = 0;
                        }
                        
                    }
                }
            }
            Console.WriteLine(String.Join("",bomb));
        }
    }
}
