using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string metric1 = Console.ReadLine();
            string metric2 = Console.ReadLine();

            double meter = 1;
            double millimeter = meter * 1000;
            double centimeter = meter * 100;
            double mile = meter * 0.000621371192;
            double inche = meter * 39.3700787;
            double kilometer = meter * 0.001;
            double feet = meter * 3.2808399;
            double yard = meter * 1.0936133;




        }
    }
}
