using System;

namespace _04._EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "one")
                {
                    secondPlayerEggs--;
                    if (secondPlayerEggs == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                        break;
                    }
                }

                if (command == "two")
                {
                    firstPlayerEggs--;
                    if (firstPlayerEggs == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                        break;
                    }
                }

                if (command == "End of battle")
                {
                    Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                    Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
                    break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
