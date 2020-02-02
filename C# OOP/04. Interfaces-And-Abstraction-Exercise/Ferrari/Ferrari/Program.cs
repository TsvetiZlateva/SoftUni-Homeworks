using System;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            Ferrari f = new Ferrari(driverName);

            Console.WriteLine($"{f.Model}/{f.Brakes()}/{f.Gas()}/{f.DriverName}");
        }
    }
}
