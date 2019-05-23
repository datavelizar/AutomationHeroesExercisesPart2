namespace P01_RawData
{
    class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double pressure, int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
