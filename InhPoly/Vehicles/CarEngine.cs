﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class CarEngine : Engine
    {
        public CarEngine(int horsepower,FuelType aFueltype)
            :base(horsepower,aFueltype)
        {
            HorsePower = 100;
            FuelType1=FuelType.Unleaded;
        }
        
        
    }
}
