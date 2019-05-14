using System;

namespace _02._EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            double couvertPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            var cakePrice = (10.0 / 100) * budget;

            if (numberOfGuests >= 10 && numberOfGuests <= 15)
            {
                couvertPrice = couvertPrice - (15.0 / 100 * couvertPrice);
            }

            if (numberOfGuests > 15 && numberOfGuests <= 20)
            {
                couvertPrice = couvertPrice - (20.0 / 100 * couvertPrice);
            }

            if (numberOfGuests > 20)
            {
                couvertPrice = couvertPrice - (25.0 / 100 * couvertPrice);
            }

            
            var totalSum = numberOfGuests * couvertPrice + cakePrice;

            double moneyLeft = budget - totalSum;
            
            if (moneyLeft >= 0)
            {
                Console.WriteLine("It is party time! {0:0.00} leva left.", moneyLeft);

            }
            else
            {
                Console.WriteLine("No party! {0:0.00} leva needed.", Math.Abs(moneyLeft));
            }

        }
    }
}
