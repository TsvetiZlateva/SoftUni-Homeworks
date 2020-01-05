﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num = i + j + 1;
                    if (num <= n)
                    {
                        Console.Write(num + " ");
                    }
                    else
                    {
                        int num1 = 2 * n - num;
                        Console.Write(num1 + " ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
