using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerL = double.Parse(Console.ReadLine());
            double wineL = double.Parse(Console.ReadLine());
            double rakiaL = double.Parse(Console.ReadLine());
            double wiskeyL = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double beerPrice = rakiaPrice - rakiaPrice * 0.80;
            double winePrice = rakiaPrice - rakiaPrice * 0.40;

            double bill = wiskeyPrice * wiskeyL + rakiaPrice * rakiaL + beerPrice * beerL + winePrice * wineL;

            Console.WriteLine("{0:f2}", bill);

        }
    }
}
