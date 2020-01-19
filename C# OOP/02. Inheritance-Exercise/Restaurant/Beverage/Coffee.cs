﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverage
{
    public class Coffee : HotBeverage
    {
        private const double coffeeMilliliters = 50;
        private const decimal coffeePrice = 3.50m;

        public Coffee(string name, double caffeine) : base(name, coffeePrice, coffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public static double CoffeeMilliliters => coffeeMilliliters;

        public static decimal CoffeePrice => coffeePrice;

        public double Caffeine { get; set; }
        

    }
}
