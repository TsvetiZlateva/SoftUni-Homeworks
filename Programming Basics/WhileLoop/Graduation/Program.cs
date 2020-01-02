using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grades = 0;
            double sum = 0;

            while (grades <= 11)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum = sum + grade;
                    grades++;
                }
            }

            sum = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
        }
    }
}
