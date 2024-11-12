using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string make, string model, bool hasSideCar)
            : base(make, model, new MotorCycleEngine(200, FuelType.Leaded))
        {
            HasSideCar = hasSideCar;
        }
    }
}
