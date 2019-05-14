using System;

namespace _06._EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal basketPrice = 1.5M;
            decimal wreathPrice = 3.8M;
            decimal bunnyPrice = 7;
            decimal grandTotalPurchase = 0;

            long basketCount = 0;
            long wreathCount = 0;
            long bunnyCount = 0;
            int numberOfClients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfClients; i++)
            {
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input != "Finish")
                    {
                        switch (input)
                        {
                            case "basket": basketCount++; break;
                            case "wreath": wreathCount++; break;
                            case "chocolate bunny": bunnyCount++; break;
                            default: break;
                        }
                    }
                    else
                    {
                        var numberOfPurchases = basketCount + wreathCount + bunnyCount;
                        var totalBasketPrice = basketPrice * basketCount;
                        var totalWreathPrice = wreathPrice * wreathCount;
                        var totalBunnyPrice = bunnyPrice * bunnyCount;

                        var totalFinalPrice = totalBasketPrice + totalWreathPrice + totalBunnyPrice;
                        if (numberOfPurchases % 2 == 0)
                        {
                            totalFinalPrice -= (totalFinalPrice * 20) / 100;
                        }

                        Console.WriteLine("You purchased {0} items for {1:0.00} leva.", numberOfPurchases, totalFinalPrice);

                        grandTotalPurchase += totalFinalPrice;

                        basketCount = 0;
                        wreathCount = 0;
                        bunnyCount = 0;

                        break;
                    }
                }
            }

            decimal averageClientPurchase = grandTotalPurchase / numberOfClients;

            Console.WriteLine("Average bill per client is: {0:0.00} leva.", averageClientPurchase);
        }
    }
}
