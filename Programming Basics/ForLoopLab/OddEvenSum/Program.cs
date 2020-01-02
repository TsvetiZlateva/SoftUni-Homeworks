using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }

            }

            int difference = Math.Abs(evenSum - oddSum);

            if (difference == 0)
            {
                Console.WriteLine("Yes, sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + difference);
            }
        }
    }
}
