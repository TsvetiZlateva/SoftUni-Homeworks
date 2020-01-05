using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                double studioPrice = num * 50;
                double appPrice = num * 65;

                if (num > 7 && num <= 14)
                {
                    double studioDiscount = studioPrice - studioPrice * 0.05;

                    Console.WriteLine($"Apartment: {appPrice:f2} lv.");
                    Console.WriteLine($"Studio: {studioDiscount:f2} lv.");
                }
                else if (num > 14)
                {
                    double studioDiscount = studioPrice - studioPrice * 0.30;
                    double appDiscount = appPrice - appPrice * 0.10;

                    Console.WriteLine($"Apartment: {appDiscount:f2} lv.");
                    Console.WriteLine($"Studio: {studioDiscount:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {appPrice:f2} lv.");
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                }
            }
            else if (month == "June" || month == "September")
            {
                double studioPrice = num * 75.20;
                double appPrice = num * 68.70;

                if (num > 14)
                {
                    double studioDiscount = studioPrice - studioPrice * 0.20;
                    double appDiscount = appPrice - appPrice * 0.10;

                    Console.WriteLine($"Apartment: {appDiscount:f2} lv.");
                    Console.WriteLine($"Studio: {studioDiscount:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {appPrice:f2} lv.");
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                }
            }
            else if (month == "July" || month == "August")
            {
                double studioPrice = num * 76;
                double appPrice = num * 77;

                if (num > 14)
                {
                    double appDiscount = appPrice - appPrice * 0.10;

                    Console.WriteLine($"Apartment: {appDiscount:f2} lv.");
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {appPrice:f2} lv.");
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                }
            }
        }
    }
}
