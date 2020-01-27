using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public double Money
        {
            get => this.money;

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public string Name { get => name; private set => name = value; }
        public List<Product> Bag { get => bag; private set => bag = value; }

        public void Buy(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                Bag.Add(product);

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
