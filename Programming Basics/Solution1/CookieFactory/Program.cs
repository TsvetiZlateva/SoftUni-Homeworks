using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            bool flour = false;
            bool eggs = false;
            bool sugar = false;

            for (int i = 1; i <= batches; i++)
            {
             
                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Bake!")
                    {
                        if (flour == true && eggs == true && sugar == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            flour = false;
                            eggs = false;
                            sugar = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            product = Console.ReadLine();
                           
                        }
                    }
                    switch (product)
                    {
                        case "flour": flour = true; break;
                        case "eggs": eggs = true; break;
                        case "sugar": sugar = true; break;
                    }
                }

                
            }
        }
    }
}
