using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) * 0.01;

            double volume = lenght * width * hight;
            double litres = volume * 0.001;
            double water = litres * (1 - percent);
            
            Console.WriteLine("{0:F3}", water);
        }
    }
}
