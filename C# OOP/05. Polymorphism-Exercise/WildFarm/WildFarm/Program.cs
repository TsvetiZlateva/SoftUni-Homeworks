using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input = Console.ReadLine();
            
            while (input.ToLower() != "end")
            {
                var tokens = input.Split(" ");
                string[] foods = Console.ReadLine().Split(" ");

                var animalType = tokens[0];
                var foodType = foods[0];
                int food = int.Parse(foods[1]);

                switch (animalType)
                {
                    case "Cat":
                        Cat cat = new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                        animals.Add(cat);
                        cat.AskForFood();
                        if (foodType == "Vegetable" || foodType == "Meat")
                        {
                            cat.EatFood(food);
                            cat.IncreaseWeight();
                        }
                        else
                        {
                            Console.WriteLine($"Cat does not eat {foodType}!");
                        }
                        break;

                    case "Tiger":
                        Tiger tiger = new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                        animals.Add(tiger);
                        tiger.AskForFood();
                        if (foodType == "Meat")
                        {
                            tiger.EatFood(food);
                            tiger.IncreaseWeight();
                        }
                        else
                        {
                            Console.WriteLine($"Tiger does not eat {foodType}!");
                        }
                        break;

                    case "Dog":
                        Dog dog = new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                        animals.Add(dog);
                        dog.AskForFood();
                        if (foodType == "Meat")
                        {
                            dog.EatFood(food);
                            dog.IncreaseWeight();
                        }
                        else
                        {
                            Console.WriteLine($"Dog does not eat {foodType}!");
                        }
                        break;

                    case "Mouse":
                        Mouse mouse = new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                        animals.Add(mouse);
                        mouse.AskForFood();
                        if (foodType == "Vegetable" || foodType == "Fruit")
                        {
                            mouse.EatFood(food);
                            mouse.IncreaseWeight();
                        }
                        else
                        {
                            Console.WriteLine($"Mouse does not eat {foodType}!");
                        }
                        break;

                    case "Hen":
                        Hen hen = new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                        animals.Add(hen);
                        hen.AskForFood();
                        hen.EatFood(food);
                        hen.IncreaseWeight();
                        break;

                    case "Owl":
                        Owl owl = new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                        animals.Add(owl);
                        owl.AskForFood();
                        if (foodType == "Meat")
                        {
                            owl.EatFood(food);
                            owl.IncreaseWeight();
                        }
                        else
                        {
                            Console.WriteLine($"Owl does not eat {foodType}!");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
