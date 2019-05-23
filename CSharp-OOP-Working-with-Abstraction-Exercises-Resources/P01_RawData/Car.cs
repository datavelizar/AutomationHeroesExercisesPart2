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
        public Tire[] tires = new Tire[4];

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engineSpeed = engine.EngineSpeed;
            this.enginePower = engine.EnginePower;
            this.cargoWeight = cargo.CargoWeight;
            this.cargoType = cargo.CargoType;
            this.tires = tires;
        }
    }
}
