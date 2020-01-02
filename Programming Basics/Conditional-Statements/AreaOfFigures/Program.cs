using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double areaSquare = Math.Round(a * a, 3);
                Console.WriteLine(areaSquare);
            }
            else if (figure == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                double areaRectangle = Math.Round(firstSide * secondSide, 3);
                Console.WriteLine(areaRectangle);
            }
            else if (figure =="circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areaCircle = Math.Round(Math.PI * r * r, 3);
                Console.WriteLine(areaCircle);
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double areaTriangle = Math.Round((side * h) / 2, 3);
                Console.WriteLine(areaTriangle);
            }

        }
    }
}
