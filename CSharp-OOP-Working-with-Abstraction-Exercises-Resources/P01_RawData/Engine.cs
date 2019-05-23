using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = EngineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
