using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Birds
{
    public class Hen:Bird
    {
        public Hen(string name, double weight, double wingSize) : 
            base(name, weight, wingSize)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void IncreaseWeight()
        {
            this.Weight += this.FoodEaten * 0.35;
        }
    }
}
