using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            StationaryPhone phone = new StationaryPhone();
            Smartphone smartPhone = new Smartphone();

            var numbers = Console.ReadLine().Split(" ");
            var sites = Console.ReadLine().Split(" ");
            string x = "^[0-9]*$";
            //string y = @"[a-zA-Z._^%$#!~@,-]";

            foreach (var n in numbers)
            {
                if (!Regex.IsMatch(n, x))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                else
                {
                    if (n.Length == 7)
                    {
                        Console.WriteLine(phone.Dial(n)); 
                    }
                    if (n.Length == 10)
                    {
                        Console.WriteLine(smartPhone.Dial(n)); 
                    }
                }
            }

            foreach (var s in sites)
            {
                if (s.FirstOrDefault(c => char.IsDigit(c)) != 0)
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                Console.WriteLine(smartPhone.Browse(s)); 
            }
        }
    }
}
