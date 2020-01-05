using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double length = a + 2 * 0.30;
            double width = b + 2 * 0.30;
            double SCover = num * (length * width);
            double SSquare = num * ((a / 2) * (a / 2));
            double priceUSD = SCover * 7 + SSquare * 9;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine("{0:f2} USD", priceUSD);
            Console.WriteLine("{0:f2} BGN", priceBGN);
            
        }
    }
}
