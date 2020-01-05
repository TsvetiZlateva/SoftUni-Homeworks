﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
   
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < (2 * n); i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstSum += num;
                }
                else if (i >= n)
                {
                    secondSum += num;
                }

          
                
            }

            int difference = Math.Abs(firstSum - secondSum);

            if (difference == 0)
            {
                Console.WriteLine("Yes, sum = " + firstSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + difference);
            }
        }
    }
}
