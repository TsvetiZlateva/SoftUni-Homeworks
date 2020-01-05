using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fine = 0;
            int countFacebook = 0;
            int countInstagram = 0;
            int countReddit = 0;

            for (int i = 0; i < tabs; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    countFacebook++;
                }
                if (site == "Instagram")
                {
                    countInstagram++;
                }
                if (site == "Reddit")
                {
                    countReddit++;
                }

                fine = countFacebook * 150 + countInstagram * 100 + countReddit * 50;
             

                if (salary <= fine)
                {
                    break;
                }
                
            }
            
            if (salary <= fine)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - fine);
            }
        }
    }
}
