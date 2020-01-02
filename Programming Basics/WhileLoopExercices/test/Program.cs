using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range[1...100]: ");
            var num = int.Parse(Console.ReadLine());
            while (num <= 0 || num > 100)
            {
                Console.WriteLine("Invalid Number!");
                Console.Write("Еnter a number in the range[1...100]: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
