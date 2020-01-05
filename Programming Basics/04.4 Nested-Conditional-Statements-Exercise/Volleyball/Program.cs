using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double gamesSofia = (48 - h) * 3.0 / 4 + 2.0 / 3 * p;
            double gamesTown = h;
            double games = gamesSofia + gamesTown;

            if (year == "leap")
            {
                double allGames = Math.Floor(games + games * 0.15);

                Console.WriteLine(allGames);
            }
            else
            {
                Console.WriteLine(Math.Floor(games));
            }
        }
    }
}
