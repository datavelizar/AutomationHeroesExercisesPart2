//Read a list of integers and print largest 3 of them. If there are less than 3, print all of them.

using System;
using System.Linq;

namespace _04._Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray().OrderBy(n => n).ToArray();

            //Array.Sort(numbersArray);

            for (int i = numbersArray.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (j < 3)
                {
                    Console.Write(numbersArray[i] + " ");
                }
                else { break; }
            }

        }
    }
}
