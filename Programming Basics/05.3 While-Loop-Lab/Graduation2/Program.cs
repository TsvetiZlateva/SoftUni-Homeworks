using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grades = 1;
            double sum = 0;
            int failed = 0;

            while (grades <= 12 && failed < 2)
            {
                double grade = double.Parse(Console.ReadLine());


                if (grade >= 4)
                {
                    sum = sum + grade;
                    grades++;
                }
                else
                {
                    failed++;
                }
            }

            if (failed < 2)
                {
                    sum = sum / 12;
                    Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
                }
            else
                Console.WriteLine($"{name} has been excluded at {grades} grade");

            
        }
    }
}
