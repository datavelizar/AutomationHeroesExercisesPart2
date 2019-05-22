using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal[]> orders = new Dictionary<string, decimal[]>();

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split(" ");

                if (inputArr[0] != "buy")
                {
                    var parsedPrice = decimal.Parse(inputArr[1]);
                    var parsedQuantity = decimal.Parse(inputArr[2]);

                    if (orders.ContainsKey(inputArr[0]))
                    {
                        orders[inputArr[0]][0] = parsedPrice;
                        orders[inputArr[0]][1] += parsedQuantity;
                    }
                    else
                    {                        
                        var a = new Decimal[] { parsedPrice, parsedQuantity };
                        orders.Add(inputArr[0], a);
                    }
                }
                else
                {
                    foreach (var item in orders)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]}");
                    }
                    //print output
                    break;
                }
            }
        }
    }
}
