using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food
{
    public class Cake : Dessert
    {
        private const double grams = 250;
        private const double calories = 1000;
        private const decimal cakePrice = 5m;

        public Cake(string name, decimal cakePrice, double grams, double calories) : base(name, cakePrice, grams, calories)
        {
        }

        public override double Grams => grams;

        public override double Calories => calories;

        public override decimal Price => cakePrice;
    }
}
