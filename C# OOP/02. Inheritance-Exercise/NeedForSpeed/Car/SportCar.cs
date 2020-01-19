using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Car
{
    public class SportCar : Car
    {
        private const double defaultFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public new double FuelConsumption = defaultFuelConsumption;

        public override void Drive(double kilometers)
        {
            double leftFuel = this.Fuel - this.FuelConsumption * kilometers;

            if (leftFuel >= 0)
            {
                this.Fuel = leftFuel;
            }
        }
    }
}
