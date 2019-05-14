using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs = int.Parse(Console.ReadLine());

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["red"] = 0;
            dict["orange"] = 0;
            dict["blue"] = 0;
            dict["green"] = 0;

            for (int i = 0; i < numberOfEggs; i++)
            {
                string currentColor = Console.ReadLine();
                switch (currentColor)
                {
                    case "red": red++; dict["red"] = red; break;
                    case "orange": orange++; dict["orange"] = orange; break;
                    case "blue": blue++; dict["blue"] = blue; break;
                    case "green": green++; dict["green"] = green; break;
                }


            }

            var maxValue = dict.Values.Max();
            var keyOfMaxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxValue} -> {keyOfMaxValue}");
        }
    }
}
