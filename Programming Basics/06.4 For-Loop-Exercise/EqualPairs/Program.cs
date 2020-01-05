using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
  
            int sum1 = 0;
            int sum2 = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    sum1 = a + b;
                }
                else
                {
                    sum2 = a + b;
                    diff = Math.Abs(sum2 - sum1);

                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    sum1 = sum2;
                    
                }
            }

            if (diff == 0)
            {
                Console.WriteLine("Yes, value = " + sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff = " + maxDiff);
            }
            
        }
    }
}
