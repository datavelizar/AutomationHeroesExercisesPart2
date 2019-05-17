using System;
using System.Collections.Generic;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
            string input = "3 Motes 5 stones 5 Shards"; //Console.ReadLine();

            string[] inputArr = input.Split(" ");

            int quantity = 0;
            string material = "";

            Dictionary<string, int> materials = new Dictionary<string, int>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (i % 2 == 0) { quantity = int.Parse(inputArr[i]); }
                else { material = inputArr[i].ToLower(); }

                if (materials.ContainsKey(material))
                {
                    materials[material] += quantity;

                    
                }
                else
                {
                    materials.Add(material, 0);
                }

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
}
