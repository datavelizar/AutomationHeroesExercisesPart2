using System;

using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];

                Engine engine = new Engine(int.Parse(parameters[1]), int.Parse(parameters[2]));

                Cargo cargo = new Cargo(int.Parse(parameters[3]), parameters[4]);

                Tire tire1 = new Tire(double.Parse(parameters[5]), int.Parse(parameters[6]));
                Tire tire2 = new Tire(double.Parse(parameters[7]), int.Parse(parameters[8]));
                Tire tire3 = new Tire(double.Parse(parameters[9]), int.Parse(parameters[10]));
                Tire tire4 = new Tire(double.Parse(parameters[11]), int.Parse(parameters[12]));

                Tire[] tires = new Tire[] { tire1, tire2, tire3, tire4 };

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                PrintFragile(cars);
            }
            else if (command == "flamable")
            {
                PrintFlamable(cars);
            }
        }

        private static void PrintFlamable(List<Car> cars)
        {
            List<string> flamable = cars
                .Where(x => x.cargoType == "flamable" && x.enginePower > 250)
                .Select(x => x.model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }

        private static void PrintFragile(List<Car> cars)
        {
            List<string> fragile = cars
                .Where(x => x.cargoType == "fragile" && x.tires.Any(y => y.TirePressure < 1))
                .Select(x => x.model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
    }
}
