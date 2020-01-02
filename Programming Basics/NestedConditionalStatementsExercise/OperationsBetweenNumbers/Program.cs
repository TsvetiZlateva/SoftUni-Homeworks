using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == '+')
            {
                double result = N1 + N2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
            }
            else if (symbol == '-')
            {
                double result = N1 - N2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
            }
            else if (symbol == '*')
            {
                double result = N1 * N2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
            }
            else if (symbol == '/')
            {
                if (N2 != 0)
                {
                    double result = N1 / N2;

                    Console.WriteLine($"{N1} {symbol} {N2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (symbol == '%')
            {
                if (N2 != 0)
                {
                    double result = N1 % N2;
                                    
                    Console.WriteLine($"{N1} {symbol} {N2} = {result}");              
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
        }
    }
}
