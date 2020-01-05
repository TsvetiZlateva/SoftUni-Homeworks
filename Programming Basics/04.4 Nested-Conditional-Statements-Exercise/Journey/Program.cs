using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (buget <= 100)
            {
                if (season == "summer")
                {
                    double moneySpent = buget * 0.30;

                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - " + "{0:f2}", moneySpent);
                }
                else if (season == "winter")
                {
                    double moneySpent = buget * 0.70;

                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - " + "{0:f2}", moneySpent);
                }
            }
            else if (buget <= 1000 && buget > 100)
            {
                if (season == "summer")
                {
                    double moneySpent = buget * 0.40;

                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - " + "{0:f2}", moneySpent);
                }
                else if (season == "winter")
                {
                    double moneySpent = buget * 0.80;

                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - " + "{0:f2}", moneySpent);
                }
            }
            else if (buget > 1000)
            {
                double moneySpent = buget * 0.90;

                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - " + "{0:f2}", moneySpent);
            }
        }
    }
}
