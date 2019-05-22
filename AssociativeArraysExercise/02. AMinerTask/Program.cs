//You are given a sequence of strings, each on a new line.Every odd line on the console is representing a resource(e.g.Gold, Silver, Copper, and so on), and every even – quantity.Your task is to collect the resources and print them each on a new line.
//Print the resources and their quantities in format:
//{resource} –> {quantity}
//The quantities inputs will be in the range[1 … 2 000 000 000]

using System;
using System.Collections.Generic;

namespace _02._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource;
            int quantity = 0;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            do
            {
                resource = Console.ReadLine();

                if (resource == "stop") { break; }

                quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            } while (true);

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
