using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());


            if (flowers == "Roses")
            {
                if (num > 80)
                {
                    double price = (num * 5) - ((num * 5) * 0.10);
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
                else if (num <= 80)
                {
                    double price = num * 5;
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
            }
            else if (flowers == "Dahlias")
            {
                if (num > 90)
                {
                    double price = (num * 3.80) - ((num * 3.80) * 0.15);
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
                else if (num <= 90)
                {
                    double price = num * 3.80;
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
            }
            else if (flowers == "Tulips")
            {
                if (num > 80)
                {
                    double price = (num * 2.80) - ((num * 2.80) * 0.15);
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
                else if (num <= 80)
                {
                    double price = num * 2.80;
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
            }
            else if (flowers == "Narcissus")
            {
                if (num < 120)
                {
                    double price = (num * 3) + ((num * 3) * 0.15);
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
                else if (num >= 120)
                {
                    double price = num * 3;
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
            }
            else if (flowers == "Gladiolus")
            {
                if (num < 80)
                {
                    double price = (num * 2.50) + ((num * 2.50) * 0.20);
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
                else if (num >= 80)
                {
                    double price = num * 2.50;
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", num, flowers, moneyLeft);
                    }
                    else if (buget < price)
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", moneyNeeded);
                    }
                }
            }
        }
    }
}
