using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double totalCalories = 0;
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Pizza pizza = new Pizza(input[1]);

                var input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Dough dough = new Dough(input2[1], input2[2], double.Parse(input2[3]));

                var input3 = Console.ReadLine();

                while (input3 != "END")
                {
                    if (input3 == "END")
                    {
                        break;
                    }

                    var tokens = input3.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));
                    pizza.AddTopping(topping);

                    input3 = Console.ReadLine();
                }

                double toppungCalories = 0;
                foreach (var topping in pizza.Toppings)
                {
                    toppungCalories += topping.CalculateCalories();
                }

                totalCalories = dough.CalculateCalories() + toppungCalories;
                Console.WriteLine($"{pizza.Name} - {totalCalories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
