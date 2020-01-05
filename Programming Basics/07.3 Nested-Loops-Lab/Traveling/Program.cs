using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            double buget = 0;
            double money = 0;
            bool success;

            while (true)
            {
                
                destination = Console.ReadLine();
               

                if (destination != "End")
                {
                    buget = double.Parse(Console.ReadLine());
                    success = false;

                    while (!success)
                    {
                        double savedMoney = double.Parse(Console.ReadLine());
                        money += savedMoney;

                        if (money >= buget)
                        {
                            money = 0;
                            Console.WriteLine($"Going to {destination}!");
                            success = true;
                        }
                    }
                }
                else
                {
                    break;
                }

            }
           
        }
    }
}
