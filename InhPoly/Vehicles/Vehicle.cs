﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public Engine EngineType { get; set; }  
        public Vehicle(string make, string model, Engine engineType)
        {
            Make = make;
            Model = model;
            EngineType = engineType;
            
        }

        public int Speed { get; set; }


    }
}
