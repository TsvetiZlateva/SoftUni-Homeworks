using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private const string model = "488-Spider";

        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
            this.Model = model;
        }

        public string Model { get; private set; }
        public string DriverName { get; set; }
        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }
    }
}
