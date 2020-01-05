using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsSum = stepsSum + stepsToHome;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    stepsSum = stepsSum + steps;

                    if (stepsSum >= 10000)
                        break;
                }
            }
            if (stepsSum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
            }
        }
    }
}
