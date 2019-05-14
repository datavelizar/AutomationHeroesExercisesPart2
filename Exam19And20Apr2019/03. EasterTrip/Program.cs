using System;

namespace _03._EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double pricePerNight = 0.00;

            if (destination == "France")
            {
                if (dates == "21-23") { pricePerNight = 30; }
                if (dates == "24-27") { pricePerNight = 35; }
                if (dates == "28-31") { pricePerNight = 40; }
            }

            if (destination == "Italy")
            {
                if (dates == "21-23") { pricePerNight = 28; }
                if (dates == "24-27") { pricePerNight = 32; }
                if (dates == "28-31") { pricePerNight = 39; }
            }

            if (destination == "Germany")
            {
                if (dates == "21-23") { pricePerNight = 32; }
                if (dates == "24-27") { pricePerNight = 37; }
                if (dates == "28-31") { pricePerNight = 43; }
            }
            
            var tripsExpenses = pricePerNight * numberOfNights;

            Console.WriteLine("Easter trip to {0} : {1:0.00} leva.", destination, tripsExpenses);
        }
    }
}
