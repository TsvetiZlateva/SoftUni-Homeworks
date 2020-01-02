using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
      
            int moneyGiven = 0;
            int numToys = 0;
            int evenBirthdays = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 !=0)
                {
                    numToys++;

                }
                else
                {
                    moneyGiven += i * 10 / 2;
                
                    evenBirthdays++;
                }
              
            }

            
            double sumToys = numToys * toyPrice;
            double sumMoney = moneyGiven - evenBirthdays;
            double sum = sumMoney + sumToys;
            double difference = Math.Abs(sum - priceWM);

            if (priceWM <= sum)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:f2}");
            }
        }
    }
}
