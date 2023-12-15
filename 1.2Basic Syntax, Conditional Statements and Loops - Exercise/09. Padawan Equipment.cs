using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int numberStudents = int.Parse(Console.ReadLine());
            double priceForLighsabers = double.Parse(Console.ReadLine());
            double priceForRobes = double.Parse(Console.ReadLine());
            double priceForBelts = double.Parse(Console.ReadLine());


            int numberLighsabers = (int)Math.Ceiling(numberStudents * 1.1);
            int freeCauntBelts = (int)(numberStudents / 6);

            double moneyForLighsabers = numberLighsabers * priceForLighsabers;
            double moneyForBelt = (numberStudents - freeCauntBelts) * priceForBelts;
            double moneyForRobes = numberStudents * priceForRobes;
            double finishPrice = moneyForLighsabers + moneyForBelt + moneyForRobes;

            if (moneyAmount < finishPrice)
            {
                Console.WriteLine($" John will need {(finishPrice - moneyAmount):f2}lv more.");
            }
            else if (moneyAmount>= finishPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {finishPrice:f2}lv.");
            }
        }
    }
}
