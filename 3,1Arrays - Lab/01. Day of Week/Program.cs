using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7];

            week[0] = "Monday";
            week[1] = "Tuesday";
            week[2] = "Wednesday";
            week[3] = "Thursday";
            week[4] = "Friday";
            week[5] = "Saturday";
            week[6] = "Sunday";

            int number =int.Parse(Console.ReadLine());
            if (number>=1 && number<=7)
            {
                Console.WriteLine(week[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
