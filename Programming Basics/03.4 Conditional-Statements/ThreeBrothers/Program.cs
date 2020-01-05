using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());

            double time = 1 / (1 / A + 1 / B + 1 / C);
            double totalTime = time + time * 0.15;
            double timeLeft = D - totalTime;
            double timeNeeded = totalTime - D;
     
            Console.WriteLine($"Cleaning time: {totalTime:f2}");

            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeNeeded)} hours.");
            }
        }
    }
}
