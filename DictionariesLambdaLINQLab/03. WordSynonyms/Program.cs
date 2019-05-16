using System;
using System.Collections.Generic;

namespace _03._WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> synonymDictionary = new Dictionary<string, List<string>>();
            int numberOfPairLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPairLines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymDictionary.ContainsKey(word))
                {
                    synonymDictionary.Add(word, new List<string> { synonym });
                }
                else
                {
                    synonymDictionary[word].Add(synonym);
                }
            }

            foreach (var word in synonymDictionary)
            {
                Console.Write($"{word.Key} - ");

                for (int i = 0; i < word.Value.Count; i++)
                {
                    if (i < word.Value.Count - 1)
                    {
                        Console.Write($"{ word.Value[i]}, ");
                    }
                    else
                    {
                        Console.Write($"{ word.Value[i]}");
                    }

                }
                Console.WriteLine();
                
            }
        }
    }
}
