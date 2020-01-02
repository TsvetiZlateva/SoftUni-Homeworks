using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BG = USD * 1.79549;
            double result = Math.Round(BG, 2);

            Console.WriteLine(result);
        }
    }
}
