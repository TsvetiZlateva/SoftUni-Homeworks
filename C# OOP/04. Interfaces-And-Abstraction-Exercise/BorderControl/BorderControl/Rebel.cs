using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel:IBuyer
    {
        private int food = 0;
        
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = this.food;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get ; set ; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
