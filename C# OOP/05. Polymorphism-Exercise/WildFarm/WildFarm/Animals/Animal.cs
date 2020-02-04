using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public virtual void AskForFood()
        {

        }

        public void EatFood(int food)
        {
            this.FoodEaten = food;
        }

        public virtual void IncreaseWeight()
        {
            
        }
    }
}
