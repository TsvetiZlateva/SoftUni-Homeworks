using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public class Dog:Mammal
    {
        public Dog(string name, double weight, string livingRegion) : 
            base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }
        public override void IncreaseWeight()
        {
            this.Weight += this.FoodEaten * 0.40;
        }

    }
}
