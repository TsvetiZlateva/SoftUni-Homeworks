using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesPrice = cakes * 45;
            double wafersPrice = wafers * 5.80;
            double pancakesPrice = pancakes * 3.20;
            double sum = ((cakesPrice + wafersPrice + pancakesPrice)  * cooks) * days;
            double charitySum = sum - sum / 8;

            Console.WriteLine("{0:f2}", charitySum);

        }
    }
}
