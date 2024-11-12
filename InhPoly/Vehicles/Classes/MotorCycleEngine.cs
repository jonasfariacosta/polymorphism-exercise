using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Classes.SuperClasses;

namespace Vehicles.Classes
{
    public class MotorCycleEngine : Engine

    {
        public MotorCycleEngine(int horsepower, FuelType aFueltype)
            : base(horsepower, aFueltype)
        {

        }
    }


}
