using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toystore
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int numToys = puzzles + dolls + bears + minions + trucks;

            double puzzlesPrice = puzzles * 2.60;
            double dollsPrice = dolls * 3.00;
            double bearsPrice = bears * 4.10;
            double minionsPrice = minions * 8.20;
            double trucksPrice = trucks * 2.00;

            double totalPrice = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;

            if (numToys < 50)
            {
                double profit = totalPrice - totalPrice * 0.10;

                if (profit > excursion)
                {
                    double balance = profit - excursion;
                    Console.WriteLine("Yes! {0:f2} lv left.", balance);
                }
                else if (profit < excursion)
                {
                    double lack = excursion - profit;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", lack);
                }
            }
            else if (numToys >= 50)
            {
                double discount = totalPrice - totalPrice * 0.25;
                double profit = discount - discount * 0.10;

                if (profit >= excursion)
                {
                    double balance = profit - excursion;
                    Console.WriteLine("Yes! {0:f2} lv left.", balance);
                }
                else if (profit < excursion)
                {
                    double lack = excursion - profit;
                    Console.WriteLine("Not enough money! {0:f2} lv needed.", lack);
                }
            }
        }
    }
}
