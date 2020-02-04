using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption+1.6, tankCapacity)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            var truckFuelAmount = fuelAmount*0.95;
            if (truckFuelAmount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                double fuelSum = this.FuelQuantity + truckFuelAmount;
                if (this.TankCapacity < fuelSum)
                {
                    Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += truckFuelAmount;
                }
            }
        }
    }
}
