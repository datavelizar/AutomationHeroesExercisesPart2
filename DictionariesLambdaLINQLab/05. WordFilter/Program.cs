//Read an array of strings, take only words which length is even. Print each word on a new line.

using System;
using System.Linq;

namespace _05._WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").Where(w => w.Length % 2 == 0).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
