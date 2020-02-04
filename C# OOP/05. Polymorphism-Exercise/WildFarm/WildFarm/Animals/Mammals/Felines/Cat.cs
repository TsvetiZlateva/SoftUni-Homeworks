using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat:Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : 
            base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void IncreaseWeight()
        {
            this.Weight += this.FoodEaten * 0.30;
        }
    }
}
