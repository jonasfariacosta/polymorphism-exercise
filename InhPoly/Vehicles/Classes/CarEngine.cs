using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Classes.SuperClasses;

namespace Vehicles.Classes
{
    internal class CarEngine : Engine
    {
        public CarEngine(int horsepower, FuelType aFueltype)
            : base(horsepower, aFueltype)
        {

        }


    }
}
