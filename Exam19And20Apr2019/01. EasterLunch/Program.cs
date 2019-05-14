using System;

namespace _01._EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOfEasterBreads = int.Parse(Console.ReadLine());
            var numberOfEggsPlats = int.Parse(Console.ReadLine());
            var kilogramsOfCookies = int.Parse(Console.ReadLine());
            var numberOfEggs = numberOfEggsPlats * 12;

            var easterBreadPrice = 3.2;
            var pricePer12EggsPlat = 4.35;
            var cookiesKgPrice = 5.4;
            var colorPerEggPrice = 0.15;

            var totalEasterBreadSum = easterBreadPrice * numberOfEasterBreads;
            var totalNumberOfEggsSum = pricePer12EggsPlat * numberOfEggsPlats;
            var totalCookiesSum = cookiesKgPrice * kilogramsOfCookies;
            var totalEggsColorSum = numberOfEggs * colorPerEggPrice;

            var totalSum = totalEasterBreadSum + totalNumberOfEggsSum + totalCookiesSum + totalEggsColorSum;

            Console.WriteLine("{0:0.00}", totalSum);
        }
    }
}
