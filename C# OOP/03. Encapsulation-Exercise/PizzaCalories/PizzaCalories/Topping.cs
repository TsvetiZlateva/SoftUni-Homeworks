using System;

namespace PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private double weight;
        private double calories = 2;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
            this.Calories = calories;
        }
        protected string ToppingType
        {
            get => toppingType;
            private set
            {
                if (value.ToLower() != "meat"
                    && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value.ToLower();
            }

        }
        protected double Weight
        {
            get => this.weight;
            private set
            {
                if (value > 50 || value < 0)
                {
                    throw new Exception($"{this.ToppingType} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }
        public double Calories
        {
            get => this.calories;
            private set
            {
                this.calories = value;
            }
        }

        public double CalculateCalories()
        {
            double modifier = 0;

            if (this.ToppingType == "meat")
            {
                modifier = 1.2;
            }

            if (this.ToppingType == "veggies")
            {
                modifier = 0.8;
            }

            if (this.ToppingType == "cheese")
            {
                modifier = 1.1;
            }

            if (this.ToppingType == "sauce")
            {
                modifier = 0.9;
            }

            double sumCalories = this.Weight * this.Calories * modifier;
            return sumCalories;
        }

    }
}