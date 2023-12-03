using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            string day = Console.ReadLine();
            double priceForTicket = 0;

            switch (people )
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            priceForTicket = 8.45;
                            break;
                        case "Saturday":
                            priceForTicket = 9.8;
                            break;
                        case "Sunday":
                            priceForTicket = 10.46;
                            break;
                    }

                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            priceForTicket = 10.90;
                            break;
                        case "Saturday":
                            priceForTicket = 15.60;
                            break;
                        case "Sunday":
                            priceForTicket = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            priceForTicket = 15;
                            break;
                        case "Saturday":
                            priceForTicket = 20;
                            break;
                        case "Sunday":
                            priceForTicket = 22.50;
                            break;
                    }
                    break ;
            }
            double finishPrice = numberPeople * priceForTicket;
            if (people =="Students" && numberPeople >= 30 )
            {
                finishPrice *= 0.85;
            }
            if (people == "Business" && numberPeople >= 100)
            {
                finishPrice = finishPrice - (10 * priceForTicket);
            }
            if (people == "Regular" && numberPeople >= 10 && numberPeople <= 20)
            {
                finishPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {finishPrice:f2}");
        }
    }
}
