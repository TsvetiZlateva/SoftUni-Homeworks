using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallS = (L * 100) * (W * 100);
            double wardrobeS = (A * 100) * (A * 100);
            double benchS = hallS / 10;
            double freeSpace = hallS - wardrobeS - benchS;
            double dancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));

        }
    }
}
