using System;
using Animals.Cats;


namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                var parameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = parameters[0];
                var age = int.Parse(parameters[1]);
                var gender = parameters[2];

                switch (animalType)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten);
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        break;
                }
                animalType = Console.ReadLine();
            }
        }
    }
}
