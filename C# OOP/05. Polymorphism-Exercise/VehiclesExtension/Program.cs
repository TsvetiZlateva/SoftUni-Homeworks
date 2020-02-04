using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Vehicle> vehicles = new List<Vehicle>(); 

            var carInput = Console.ReadLine().Split(" ");
            Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            //vehicles.Add(car);

            var truckInput = Console.ReadLine().Split(" ");
            Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
            //vehicles.Add(truck);

            var busInput = Console.ReadLine().Split(" ");
            Bus bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var command = Console.ReadLine().Split(" ");

                if (command[0] == "Drive" && command[1] == "Car")
                {
                    car.Drive(double.Parse(command[2]));
                }

                if (command[0] == "Drive" && command[1] == "Truck")
                {
                    truck.Drive(double.Parse(command[2]));
                }

                if (command[0] == "Drive" && command[1] == "Bus")
                {
                    bus.DriveWithPeople(double.Parse(command[2]));
                }

                if (command[0] == "DriveEmpty" && command[1] == "Bus")
                {
                    bus.Drive(double.Parse(command[2]));
                }

                if (command[0] == "Refuel" && command[1] == "Car")
                {
                    car.Refuel(double.Parse(command[2]));
                }

                if (command[0] == "Refuel" && command[1] == "Truck")
                {
                    truck.Refuel(double.Parse(command[2]));
                }

                if (command[0] == "Refuel" && command[1] == "Bus")
                {
                    bus.Refuel(double.Parse(command[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
