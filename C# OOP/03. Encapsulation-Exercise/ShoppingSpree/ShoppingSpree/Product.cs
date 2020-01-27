using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name 
        {
            get => this.name;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public double Cost { get => cost; set => cost = value; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
