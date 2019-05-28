namespace P01_RawData
{
    class Car
    {

        private Engine engine;
        private Cargo cargo;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public string Model { get; private set; }


        public Engine Engine
        {
            get { return this.engine; }
            private set { this.engine = value; }
        }
        public Cargo Cargo
        {
            get { return this.cargo; }
            private set { this.cargo = value; }
        }

        public Tire[] Tires { get; set; }
    }
}
