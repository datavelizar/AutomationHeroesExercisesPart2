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
            Dictionary<string, int> junkDictionary = new Dictionary<string, int>();
            Dictionary<string, int> keyDictionary = new Dictionary<string, int>();

            keyDictionary.Add(keyMaterialsTexts[0], 0);
            keyDictionary.Add(keyMaterialsTexts[1], 0);
            keyDictionary.Add(keyMaterialsTexts[2], 0);

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split(" ");

                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (i % 2 == 0) { quantity = int.Parse(inputArr[i]); }
                    else
                    {
                        material = inputArr[i].ToLower();

                        if (keyMaterialsTexts.Any(x => x == material))
                        {
                            keyDictionary[material] += quantity;

                            if (keyDictionary[material] >= 250)
                            {
                                isFinished = true;
                                keyDictionary[material] -= 250;
                                PrintLegendary(keyMaterialsTexts, material);
                                PrintKeyDictionary(keyDictionary);
                                break;
                            }
                        }
                        else
                        {
                            if (junkDictionary.ContainsKey(material))
                            {
                                junkDictionary[material] += quantity;
                            }
                            else
                            {
                                junkDictionary.Add(material, quantity);
                            }
                        }
                    }
                }

                if (isFinished) { break; }
            }

            PrintJunk(junkDictionary);
        }

        private static void PrintLegendary(string[] keyMaterialsTexts, string material)
        {
            if (material == keyMaterialsTexts[0]) Console.WriteLine("Shadowmourne obtained!");
            if (material == keyMaterialsTexts[1]) Console.WriteLine("Valanyr obtained!");
            if (material == keyMaterialsTexts[2]) Console.WriteLine("Dragonwrath obtained!");
        }

        private static void PrintJunk(Dictionary<string, int> junk)
        {
            foreach (var item in junk.OrderBy(r => r.Key)) { Console.WriteLine($"{ item.Key}: {item.Value}"); }
        }

        private static void PrintKeyDictionary(Dictionary<string, int> keyMaterials)
        {
            foreach (var item in keyMaterials.OrderByDescending(key => key.Value).ThenBy(r => r.Key)) { Console.WriteLine($"{item.Key}: {item.Value}"); }
        }
    }
}
