using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();


            if (degrees >= 10 && degrees <= 18)
            {                
                if (time == "Morning")
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
                else if (time == "Afternoon")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
                else if (time == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (time == "Morning")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
                else if (time == "Afternoon")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
                else if (time == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
            }
            else if (degrees >= 25)
            {
                if (time == "Morning")
                {
                    string outfit = "T-Shirt";
                    string shoes = "Sandals";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
                else if (time == "Afternoon")
                {
                    string outfit = "Swim Suit";
                    string shoes = "Barefoot";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
                else if (time == "Evening")
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
                }
            }
        }
    }
}
