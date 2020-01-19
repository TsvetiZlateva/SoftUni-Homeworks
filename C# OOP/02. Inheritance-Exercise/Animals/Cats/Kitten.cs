using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Cats
{
    public class Kitten:Cat
    {
        private const string gender = "Female";
        public Kitten(string name, int age) : base(name, age, gender)
        {
        }

        public override string Gender => gender;

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
