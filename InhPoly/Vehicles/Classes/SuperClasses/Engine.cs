using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Classes.SuperClasses
{

    public abstract class Engine
    {
        public bool Running { get; set; }
        public int HorsePower { get; set; }

        public FuelType FuelType1 { get; set; }

        public Engine(int horsePower, FuelType fuelType)
        {
            HorsePower = horsePower;
            FuelType1 = fuelType;
        }

        public void Start()
        {
            Running = true;
        }
    }
}
