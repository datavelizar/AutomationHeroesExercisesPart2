using System;

namespace _05._EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {

            double sugarPacketGrams = 950.0;
            double flourPacketGrams = 750.0;

            int numberOfBreads = int.Parse(Console.ReadLine());
            int currentSugarGrams = 0;
            int currentFlourGrams = 0;
            int maxSugarGrams = int.MinValue;
            int maxFlourGrams = int.MinValue;
            long totalSugarGrams = 0;
            long totalFlourGrams = 0;

            for (int i = 0; i < numberOfBreads; i++)
            {
                currentSugarGrams = int.Parse(Console.ReadLine());
                currentFlourGrams = int.Parse(Console.ReadLine());

                if (maxSugarGrams < currentSugarGrams) { maxSugarGrams = currentSugarGrams; }
                if (maxFlourGrams < currentFlourGrams) { maxFlourGrams = currentFlourGrams; }

                totalSugarGrams += currentSugarGrams;
                totalFlourGrams += currentFlourGrams;
            }

            var neededSugarPackets = Math.Ceiling(totalSugarGrams / sugarPacketGrams);
            var neededFlourPackets = Math.Ceiling(totalFlourGrams / flourPacketGrams);

            Console.WriteLine("Sugar: {0}", neededSugarPackets);
            Console.WriteLine("Flour: {0}", neededFlourPackets);
            Console.WriteLine("Max used flour is {0} grams, max used sugar is {1} grams.", maxFlourGrams, maxSugarGrams);
        }
    }
}
