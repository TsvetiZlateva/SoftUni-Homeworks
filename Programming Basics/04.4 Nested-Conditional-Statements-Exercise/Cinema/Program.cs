using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int seats = r * c;
           
            if (ticket == "Premiere")
            {
                double ticketPrice = 12.00;
                double profit = seats * ticketPrice;

                Console.WriteLine("{0:f2}", profit + " leva");
            }
            else if (ticket == "Normal")
            {
                double ticketPrice = 7.50;
                double profit = seats * ticketPrice;

                Console.WriteLine("{0:f2}", profit + " leva");
            }
            else if (ticket == "Discount")
            {
                double ticketPrice = 5.00;
                double profit = seats * ticketPrice;

                Console.WriteLine("{0:f2}", profit + " leva");
            }
        }
    }
}
