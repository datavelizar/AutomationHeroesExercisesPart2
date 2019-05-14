using System;
using System.Collections.Generic;

namespace _06._EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfParticipants = int.Parse(Console.ReadLine());

            long points = 0;
            List<Baker> bakersList = new List<Baker>();

            for (int i = 0; i < numberOfParticipants; i++)
            {
                string bakerName = Console.ReadLine();
                Baker currentBaker = new Baker(bakerName, points);
                bakersList.Add(currentBaker);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input != "Stop")
                    {
                        currentBaker.Points += int.Parse(input);
                    }
                    else
                    {
                        Console.WriteLine($"{currentBaker.Name} has {currentBaker.Points} points.");
                        break;
                    }
                }

                var maxPointsBaker = FindBakerWithMaxPoints(bakersList);
                if (maxPointsBaker.Name == currentBaker.Name)
                {
                    Console.WriteLine($"{maxPointsBaker.Name} is the new number 1!");
                }

                points = 0;
            }

            var finalMaxPointsBaker = FindBakerWithMaxPoints(bakersList);

            Console.WriteLine($"{finalMaxPointsBaker.Name} won competition with {finalMaxPointsBaker.Points} points!");
        }

        public static Baker FindBakerWithMaxPoints(List<Baker> list)
        {
            var rememberBaker = new Baker("", 0);

            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }

            long maxPoints = long.MinValue;

            foreach (Baker baker in list)
            {
                if (baker.Points > maxPoints)
                {
                    maxPoints = baker.Points;
                    rememberBaker.Name = baker.Name;
                    rememberBaker.Points = baker.Points;
                }
            }
            return rememberBaker;
        }

        public class Baker
        {
            public string Name { get; set; }
            public long Points { get; set; }

            public Baker(string name, long points)
            {
                Name = name;
                Points = points;
            }
        }
    }
}

////SOLUTION FOR 570 points
//static void Main(string[] args)
//    {
//        int numberOfParticipants = int.Parse(Console.ReadLine());

//        long points = 0;
//        long maxPoints = long.MinValue;
//        string maxBaker = "";

//        for (int i = 0; i < numberOfParticipants; i++)
//        {
//            string bakerName = Console.ReadLine();

//            while (true)
//            {
//                string input = Console.ReadLine();

//                if (input != "Stop")
//                {
//                    points += int.Parse(input);

//                    if (points >= maxPoints )
//                    {
//                        maxPoints = points;
//                        maxBaker = bakerName;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine($"{bakerName} has {points} points.");

//                    if (maxPoints == points)
//                    {
//                        Console.WriteLine($"{bakerName} is the new number 1!");
//                    }

//                    points = 0;
//                    break;
//                }
//            }
//        }

//        Console.WriteLine($"{maxBaker} won competition with {maxPoints} points!");
//    }

//}
