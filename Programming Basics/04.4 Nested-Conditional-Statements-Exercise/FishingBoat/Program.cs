using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (season == "Spring")
            {
                if (num <= 6)
                {
                    if (num % 2 == 0)
                    {
                        double price = (3000 - 3000 * 0.10) - ((3000 - 3000 * 0.10) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 3000 - 3000 * 0.10;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }

                }
                else if (num >= 7 && num <= 11)
                {
                    if (num % 2 == 0)
                    {
                        double price = (3000 - 3000 * 0.15) - ((3000 - 3000 * 0.15) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 3000 - 3000 * 0.15;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (num >= 12)
                {
                    if (num % 2 == 0)
                    {
                        double price = (3000 - 3000 * 0.25) - ((3000 - 3000 * 0.25) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 3000 - 3000 * 0.25;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
            }
            else if (season == "Summer")
            {
                if (num <= 6)
                {
                    if (num % 2 == 0)
                    {
                        double price = (4200 - 4200 * 0.10) - ((4200 - 4200 * 0.10) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 4200 - 4200 * 0.10;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }

                }
                else if (num >= 7 && num <= 11)
                {
                    if (num % 2 == 0)
                    {
                        double price = (4200 - 4200 * 0.15) - ((4200 - 4200 * 0.15) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 4200 - 4200 * 0.15;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (num >= 12)
                {
                    if (num % 2 == 0)
                    {
                        double price = (4200 - 4200 * 0.25) - ((4200 - 4200 * 0.25) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 4200 - 4200 * 0.25;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
            }
            else if (season == "Autumn")
            {
                if (num <= 6)
                {
                    double price = 4200 - 4200 * 0.10;
                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                }
                else if (num >= 7 && num <= 11)
                {
                    double price = 4200 - 4200 * 0.15;

                    if (buget >= price)
                    {
                        double moneyLeft = buget - price;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                    }
                    else
                    {
                        double moneyNeeded = price - buget;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                    }
                }
            }
            else if (season == "Winter")
            {
                if (num <= 6)
                {
                    if (num % 2 == 0)
                    {
                        double price = (2600 - 2600 * 0.10) - ((2600 - 2600 * 0.10) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 2600 - 2600 * 0.10;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }

                }
                else if (num >= 7 && num <= 11)
                {
                    if (num % 2 == 0)
                    {
                        double price = (2600 - 2600 * 0.15) - ((2600 - 2600 * 0.15) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 2600 - 2600 * 0.15;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
                else if (num >= 12)
                {
                    if (num % 2 == 0)
                    {
                        double price = (2600 - 2600 * 0.25) - ((2600 - 2600 * 0.25) * 0.05);

                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }

                    }
                    else
                    {
                        double price = 2600 - 2600 * 0.25;
                        if (buget >= price)
                        {
                            double moneyLeft = buget - price;
                            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
                        }
                        else
                        {
                            double moneyNeeded = price - buget;
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded);
                        }
                    }
                }
            }
        }
    }
}
               
                    
