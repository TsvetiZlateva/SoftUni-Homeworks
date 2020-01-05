using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            string excercice = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            int badGradesCount = 0;
            int counter = 0;
            counter++;
            double sum = grade;
            string lastExcercice = string.Empty;

            while (maxBadGrades > badGradesCount)
            {
                excercice = Console.ReadLine();
                

                if (excercice == "Enough")
                {
                    double allGrades = sum / counter;
                    Console.WriteLine($"Average score: {(allGrades):f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastExcercice}");
                    break;
                }
                             
                sum += grade;
                counter++;
                excercice = lastExcercice;

                if (grade <= 4)
                {

                    badGradesCount++;
                }
                if (badGradesCount == maxBadGrades)
                {
                    Console.WriteLine($"You need a break, {maxBadGrades} poor grades.");
                    break;
                }
                
                grade = int.Parse(Console.ReadLine());                   
            }
        }
    }
}
