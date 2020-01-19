using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int? age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int? Age 
        { 
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value == null)
                {
                    throw new ArgumentOutOfRangeException("Invalid input!");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public virtual string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input!");
                }
                else
                {
                    this.gender = value;
                }
            }
        }

        public abstract string ProduceSound();
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(GetType().Name);
            result.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            result.AppendLine(ProduceSound());
            return result.ToString();
        }

    }
}
