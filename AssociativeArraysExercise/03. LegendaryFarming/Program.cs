using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            string material = null;
            string[] keyMaterialsTexts = { "shards", "fragments", "motes" };
            bool isFinished = false;

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();//"3 Motes 5 stones 5 Shards"; //

                string[] inputArr = input.Split(" ");

                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (i % 2 == 0) { quantity = int.Parse(inputArr[i]); }
                    if (i % 2 == 1)
                    {
                        material = inputArr[i].ToLower();

                        if (keyMaterialsTexts.Any(x => x == material))
                        {
                            keyMaterials[material] += quantity;
                            if (keyMaterials["shards"] >= 250)
                            {
                                isFinished = true;
                                keyMaterials["shards"] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                PrintKeyMaterialsDescending(keyMaterials);
                                break;
                            }

                            if (keyMaterials["fragments"] >= 250)
                            {
                                isFinished = true;
                                keyMaterials["fragments"] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                                PrintKeyMaterialsDescending(keyMaterials);
                                break;
                            }

                            if (keyMaterials["motes"] >= 250)
                            {
                                isFinished = true;
                                keyMaterials["motes"] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                PrintKeyMaterialsDescending(keyMaterials);
                                break;
                            }
                        }
                        else
                        {
                            if (junk.ContainsKey(material))
                            {
                                junk[material] += quantity;
                            }
                            else
                            {
                                junk.Add(material, quantity);
                            }
                        }
                    }
                }

                if (isFinished) { break; }
            }

            PrintJunk(junk);
        }

        private static void PrintJunk(Dictionary<string, int> junk)
        {
            foreach (var item in junk.OrderBy(r => r.Key))
            {
                Console.WriteLine($"{ item.Key}: {item.Value}");
            }
        }

        private static void PrintKeyMaterialsDescending(Dictionary<string, int> keyMaterials)
        {
            foreach (var item in keyMaterials.OrderByDescending(key => key.Value).ThenBy(r => r.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

public enum KeyMaterials
{
    shards = 0,
    fragments = 1,
    motes = 2
}
