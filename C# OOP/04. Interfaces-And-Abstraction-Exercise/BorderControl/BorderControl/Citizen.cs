using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen: ILicence, IBirth, IBuyer
    {
        private int food = 0;
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Age = age;
            this.Name = name;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = this.food;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get ; set ; }
        public int Food { get ; set ; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
