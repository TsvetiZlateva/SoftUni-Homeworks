using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int inputs = 0;

            while (true)
            {
                string book = Console.ReadLine();
                inputs++;

                if (bookToFind == book)
                {
                    Console.WriteLine($"You checked {inputs - 1} books and found it.");
                    break;
                }
                else if (inputs == capacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {inputs} books.");
                    break;
                }
            }
        }
    }
}
