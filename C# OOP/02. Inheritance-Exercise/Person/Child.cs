using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        private int age;

        public new int Age 
        { 
            get => age; 
            set
            {
                if (value <= 15)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public Child(string name, int age) : base(name, age)
        {
            this.Age = age;
        }
    }
}
