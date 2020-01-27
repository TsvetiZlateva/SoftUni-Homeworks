using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //
                List<Person> people = new List<Person>();

                var input1 = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                foreach (var p in input1)
                {
                    var tokens = p.Split("=");
                    string personName = tokens[0];
                    double money = double.Parse(tokens[1]);

                    Person person = new Person(personName, money);
                    people.Add(person);
                }

                //
                List<Product> products = new List<Product>();

                var input2 = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                foreach (var p in input2)
                {
                    var tokens = p.Split("=");
                    string productName = tokens[0];
                    double cost = double.Parse(tokens[1]);

                    Product product = new Product(productName, cost);
                    products.Add(product);
                }

                string input3 = Console.ReadLine();

                while (input3 != "END")
                {
                    if (input3 == "EDN")
                    {
                        break;
                    }

                    var tokens = input3.Split(" ");
                    var person = people.FirstOrDefault(x => x.Name == tokens[0]);
                    var product = products.FirstOrDefault(x => x.Name == tokens[1]);

                    person.Buy(product);

                    input3 = Console.ReadLine();
                }

                foreach (var p in people)
                {
                    if (p.Bag.Count > 0)
                    {
                        Console.Write($"{p.Name} - {String.Join(", ", p.Bag)}");

                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine($"{p.Name} - Nothing bought");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
