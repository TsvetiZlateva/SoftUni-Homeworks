﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = (rad * 180) / Math.PI;

            double result = Math.Round(deg, 0);

            Console.WriteLine(result);
        }
    }
}
