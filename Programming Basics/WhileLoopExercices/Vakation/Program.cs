using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vakation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyIn = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int days = 0;

            while (moneyIn < moneyNeeded)
            {
                string operation = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                days++;

                if (operation == "spend")
                {
                    spendCounter++;
                                  

                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                    else
                    {
                        double moneyLeft = moneyIn - sum;

                        if (moneyLeft < sum)
                        {
                            moneyIn = 0;
                        }
                    }
                    
                    
                    
                }
                else if (operation == "save")
                {
                    spendCounter = 0;
                    moneyIn = moneyIn + sum;
                    if (moneyIn >= moneyNeeded)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }

              
            }

        
        }
    }
}
