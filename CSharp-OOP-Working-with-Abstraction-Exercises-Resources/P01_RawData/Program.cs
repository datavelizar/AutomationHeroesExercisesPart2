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
            const int TIRE_COUNT = 4;

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];

                Engine engine = new Engine(int.Parse(parameters[1]), int.Parse(parameters[2]));

                Cargo cargo = new Cargo(int.Parse(parameters[3]), parameters[4]);

                Tire[] tires = new Tire[TIRE_COUNT];
                int tireNumber = 0;

                for (int j = 5; j < 12; j += 2)
                {
                    Tire tire = new Tire(double.Parse(parameters[j]), int.Parse(parameters[j + 1]));

                    tires[tireNumber] = tire;

                    tireNumber++;
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            List<string> carsModelsToPrint = new List<string>();

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                carsModelsToPrint = SelectFragile(cars);
            }
            else if (command == "flamable")
            {
                carsModelsToPrint = SelectFlamable(cars);
            }

            Console.WriteLine(string.Join(Environment.NewLine, carsModelsToPrint));
        }

        private static List<string> SelectFlamable(List<Car> cars)
        {
            List<string> flamable = cars
                .Where(x => x.Cargo.CargoType == "flamable")
                .Where(x => x.Engine.EnginePower > 250)
                .Select(x => x.Model)
                .ToList();

            return flamable;
        }

        private static List<string> SelectFragile(List<Car> cars)
        {
            List<string> fragile = cars
                .Where(x => x.Cargo.CargoType == "fragile")
                .Where(x => x.Tires.Any(y => y.Pressure < 1))
                .Select(x => x.Model)
                .ToList();

            return fragile;
        }
    }
}
