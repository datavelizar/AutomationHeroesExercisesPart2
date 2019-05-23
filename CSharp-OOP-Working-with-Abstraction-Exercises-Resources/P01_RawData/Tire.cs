using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Tire
    {
        public double TirePressure { get; set; }
        public int TireAge { get; set; }

        public Tire(double tirePressure, int tireAge)
        {
            this.TireAge = tireAge;
            this.TirePressure = tirePressure;
        }
    }
}
