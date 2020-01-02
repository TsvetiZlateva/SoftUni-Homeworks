using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100_to_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else if (num >= 100)
            {
                if (num <= 200)
                {
                    Console.WriteLine("Between 100 and 200");
                }
            }
            else if (num <= 200)
            {
                if (num >= 100)
                {
                    Console.WriteLine("Between 100 and 200");
                }
            }
         
        }
    }
}
