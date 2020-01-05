using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int n = number[i] - 48;

                    if (n == 0)
                    {
                        Console.WriteLine("ZERO");
                    }
                    else
                    {
                        int sum = n + 33;
                        char toPrint = Convert.ToChar(sum);

                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(toPrint);
                        }
                        Console.WriteLine();
                    }
                
            }
            
        }
    }
}
