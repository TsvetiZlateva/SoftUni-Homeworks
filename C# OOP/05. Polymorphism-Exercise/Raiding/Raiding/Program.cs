using Raiding.Creator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HeroCreator creator = null;
            List<BaseHero> group = new List<BaseHero>();
            BaseHero hero = null;


            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                switch (type.ToLower())
                {
                    case "druid":
                        creator = new DruidCreator(name);
                        hero = creator.CreateHero();
                        group.Add(hero);
                        Console.WriteLine(hero.CastAbility());
                        break;
                    case "paladin":
                        creator = new PaladinCreator(name);
                        hero = creator.CreateHero();
                        group.Add(hero);
                        Console.WriteLine(hero.CastAbility());
                        break;
                    case "rogue":
                        creator = new RogueCreator(name);
                        hero = creator.CreateHero();
                        group.Add(hero);
                        Console.WriteLine(hero.CastAbility());
                        break;
                    case "warrior":
                        creator = new WarriorCreator(name);
                        hero = creator.CreateHero();
                        group.Add(hero);
                        Console.WriteLine(hero.CastAbility());
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        lines++;
                        break;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int groupPower = 0;

            if (group.Count > 0)
            {
                foreach (var unit in group)
                {
                    groupPower += unit.Power;
                }
            }

            if (bossPower <= groupPower)
            {
                Console.WriteLine("Victory!");
            }

            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
