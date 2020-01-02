using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double racer1 = double.Parse(Console.ReadLine());
            double racer2 = double.Parse(Console.ReadLine());
            double racer3 = double.Parse(Console.ReadLine());

            double sum = racer1 + racer2 + racer3;

            if (sum <= 59)
            {
                if (sum < 10)
                {
                    Console.WriteLine("0:0{0}", sum);
                }
                else if (sum >= 10)
                {
                    Console.WriteLine("0:{0}", sum);
                }

            }
            else if (sum > 59)
            { 
                if (sum <= 119)
                {
                    double seconds = sum - 60;

                    if (seconds < 10)
                    {
                        Console.WriteLine("1:0{0}", seconds);
                    }
                    else if (seconds >= 10)
                    {
                        Console.WriteLine("1:{0}", seconds);
                    }
                }
                else if (sum > 119)
                { 
                    if (sum <= 179)
                    {
                        double seconds = sum - 120;

                        if (seconds < 10)
                        {
                            Console.WriteLine("2:0{0}", seconds);
                        }
                        else if (seconds >= 10)
                        {
                            Console.WriteLine("2:{0}", seconds);
                        }
                    }
                }
            }
        }
    }
}
