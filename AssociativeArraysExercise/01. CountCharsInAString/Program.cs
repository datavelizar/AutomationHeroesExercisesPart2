//Write a program which counts all characters in a string except space(' ').
//Print all occurrences in the following format:
//{char} -> {occurrences}

using System;
using System.Collections.Generic;

namespace _01._CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> ocurrencies = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (ocurrencies.ContainsKey(input[i]))
                    {
                        ocurrencies[input[i]]++;
                    }
                    else
                    {
                        ocurrencies.Add(input[i], 1);
                    }
                }
            }


            foreach (var item in ocurrencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
