using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int time = (h * 60 + m) + 15;
            int resultH = time / 60;
            int resultM = time % 60;

            if (resultH == 24)
            {
                Console.WriteLine($"0:{resultM:D2}");
            }
            else

            Console.WriteLine($"{resultH}:{resultM:D2}");
            
        }
    }
}
