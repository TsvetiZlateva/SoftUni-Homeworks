using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double uspeh = double.Parse(Console.ReadLine());
            double mrz = double.Parse(Console.ReadLine());

            double social = Math.Floor(mrz * 0.35);
            double excelence = Math.Floor(uspeh * 25);

            // get social bonus

            if (dohod < mrz && uspeh > 4.5 && uspeh < 5.5) 
            {
                Console.WriteLine($"You get a Social scholarship {social} BGN");
            }
            else if (dohod < mrz && uspeh >= 5.5 && excelence < social)
            {
                Console.WriteLine($"You get a Social scholarship {social} BGN");
            }

            //get excelence bonus

            else if (dohod >= mrz && uspeh >= 5.5) 
            {
               Console.WriteLine($"You get scholarship for excellent results {excelence} BGN");
            }
            else if (dohod < mrz && uspeh >= 5.5 && excelence > social)
            {
                Console.WriteLine($"You get scholarship for excellent results {excelence} BGN");
            }

            //no bonus

            else if (dohod > mrz && uspeh < 5.5 || dohod <= mrz && uspeh <= 4.5) 
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
