using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;

        public Pizza(string name)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }
        public Dough Dough
        {
            get => this.dough;
            private set
            {
                this.dough = value;
            }
        }
        public List<Topping> Toppings { get; private set; }
        public int NumberOfToppings => Toppings.Count();


        public void AddTopping(Topping topping)
        {
            if (NumberOfToppings > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            Toppings.Add(topping);
        }

    }
}
