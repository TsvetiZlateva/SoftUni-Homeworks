using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num > maxEven)
                    {
                        maxEven = num;
                    }
                    if (num < minEven)
                    {
                        minEven = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (num > maxOdd)
                    {
                        maxOdd = num;
                    }

                    if (num < minOdd)
                    {
                        minOdd = num;
                    }
                }
            }

            Console.WriteLine("OddSum = " + oddSum);
            if (minOdd == double.MaxValue)
            {
                Console.WriteLine("OddMin = No");
            }
            else
            {
                Console.WriteLine("OddMin = " + minOdd);
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = " + maxOdd);
            }
            Console.WriteLine("EvenSum = " + evenSum);
            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine("EvenMin = " + minEven);
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = " + maxEven);
            }
        }
    }
}
