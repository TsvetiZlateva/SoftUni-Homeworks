using System;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double calories = 2;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.Calories = calories;
        }
        protected string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }

                this.flourType = value.ToLower();
            }
        }
        protected string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new Exception("Invalid type of dough.");
                }

                this.bakingTechnique = value.ToLower();
            }
        }
        protected double Weight
        {
            get => this.weight;
            private set
            {
                if (value > 200 || value < 0)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
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
            double modifier1 = 0;
            double modifier2 = 0;

            if (this.FlourType == "white")
            {
                modifier1 = 1.5;
            }

            if (this.FlourType == "wholegrain")
            {
                modifier1 = 1.0;
            }

            if (this.BakingTechnique == "crispy")
            {
                modifier2 = 0.9;
            }

            if (this.BakingTechnique == "chewy")
            {
                modifier2 = 1.1;
            }

            if (this.BakingTechnique == "homemade")
            {
                modifier2 = 1.0;
            }

            double sumCalories = this.Weight * this.Calories * modifier1 * modifier2;
            return sumCalories;
        }

    }
}