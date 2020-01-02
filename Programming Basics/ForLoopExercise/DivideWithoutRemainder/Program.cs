﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    count1++;
                }
                if (num  % 3 == 0)
                {
                    count2++;
                }
                if (num % 4 == 0)
                {
                    count3++;
                }
                
            }

            double p1 = count1 / n * 100;
            double p2 = count2 / n * 100;
            double p3 = count3 / n * 100;
       

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
