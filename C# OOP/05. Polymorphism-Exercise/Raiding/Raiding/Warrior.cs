using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior:BaseHero
    {
        private readonly int power;
        private string name;

        public Warrior(string name)
        {
            this.Name = name;
            this.power = 100;
        }
        public override string Name { get => name; set => name = value; }
        public override int Power { get => power; }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
