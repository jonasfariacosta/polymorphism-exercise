using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Classes.SuperClasses;

namespace Vehicles.Classes
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string make, string model, bool hasSideCar)
            : base(make, model, new MotorCycleEngine(200, FuelType.Leaded))
        {
            HasSideCar = hasSideCar;
        }

        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType1 switch
            {
                FuelType.Unleaded => 1.5D,
                FuelType.Leaded => 1.2D,
                FuelType.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType1}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.HorsePower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (HasSideCar ? 0.8 : 1.0)}mph");
            }
        }

    }


}
