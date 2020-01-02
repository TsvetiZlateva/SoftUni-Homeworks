using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            //Алгоритъм на Евклид:
            // while b ≠ 0
            // var t := b
            // b:= a mod b
            // a:= t
            // return a

            while (b != 0)
            {
                double t = b;
                b = a % b;
                a = t;
            }

            Console.WriteLine($"{a}");
        }
    }
}
