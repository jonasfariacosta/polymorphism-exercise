using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class MotorCycleEngine : Engine

    {
        public MotorCycleEngine(int horsepower, FuelType aFueltype)
            : base(horsepower, aFueltype)
        {
            HorsePower = 200;
            FuelType1 = FuelType.Leaded;
        }
    }
    
    
}
