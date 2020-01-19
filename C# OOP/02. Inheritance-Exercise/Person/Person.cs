using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }

        public int Age
        {
            get => age;
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {this.Name}, Age: {this.Age}");
            return sb.ToString();
        }

    }
}
