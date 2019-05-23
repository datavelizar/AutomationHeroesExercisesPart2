using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Car
    {
        public string model;
        public int engineSpeed;
        public int enginePower;
        public int cargoWeight;
        public string cargoType;
        //public KeyValuePair<double, int>[] tires;
        public Tire[] tires = new Tire[4];

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engineSpeed = engine.EngineSpeed;
            this.enginePower = engine.EnginePower;
            this.cargoWeight = cargo.CargoWeight;
            this.cargoType = cargo.CargoType;
            //var tires0 = new KeyValuePair<double, int>(tires[0].TirePressure, tires[0].TireAge);
            //var tires1 = new KeyValuePair<double, int>(tires[1].TirePressure, tires[1].TireAge);
            //var tires2 = new KeyValuePair<double, int>(tires[2].TirePressure, tires[2].TireAge);
            //var tires3 = new KeyValuePair<double, int>(tires[3].TirePressure, tires[3].TireAge);
            this.tires = tires;
        }
    }
}
