using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption+1.6)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount*0.95);
        }
    }
}
