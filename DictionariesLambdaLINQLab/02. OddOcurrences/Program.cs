//Write a program that extracts from a given sequence of words all elements that present in it odd number of times(case-insensitive).
//•	Words are given in a single line, space separated.
//•	Print the result elements in lowercase, in their order of appearance.


using System;
using System.Collections.Generic;

namespace _02._OddOcurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var words = input.Split(" ");

            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i].ToLower();

                if (counts.ContainsKey(currentWord))
                {
                    counts[currentWord]++;
                }
                else
                {
                    counts.Add(currentWord, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
