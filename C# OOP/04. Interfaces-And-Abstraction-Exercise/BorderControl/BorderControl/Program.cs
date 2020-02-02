using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(" ");

                if (tokens.Length == 4)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    buyers.Add(citizen);
                }

                if (tokens.Length == 3)
                {
                    Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    buyers.Add(rebel);
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {

                var person = buyers.FirstOrDefault(p => p.Name == input);

                if (person == null)
                {
                    input = Console.ReadLine();
                    continue;
                }

                person.BuyFood();


                input = Console.ReadLine();
            }

            int allFood = 0;

            foreach (var f in buyers)
            {
                allFood += f.Food;
            }

            Console.WriteLine(allFood);
        }
    }
}
