using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Tiger:Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : 
            base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void IncreaseWeight()
        {
            this.Weight += this.FoodEaten * 1.00;
        }
    }
}
